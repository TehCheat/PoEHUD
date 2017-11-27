using System;
using System.Collections;
using System.Security.Cryptography;
using PoeHUD.Controllers;


namespace PoeHUD.Framework
{
    public class Coroutine
    {
        private readonly IEnumerator _enumerator;
        public bool IsDone { get; private set; }
        public string Name { get; set; }
        public string Owner { get; private set; }
        public bool DoWork { get; private set; }
        public bool AutoResume { get; set; } = true;
        public int TimeoutForAction { get; set; }
        public long Ticks { get; private set; } = -1;
        public CoroutinePriority Priority { get; set; } = CoroutinePriority.Normal;
        public DateTime Started { get; set; }
        public Action Action { get; private set; }

        public bool ThisIsSimple => Action != null;

        public Coroutine(Action action, int timeoutForAction, string owner, string name = null, bool autoStart = true)
        {
            DoWork = autoStart;
            Started = DateTime.Now;
            TimeoutForAction = timeoutForAction;
            Owner = owner;
            Action = action;

            IEnumerator CoroutineAction(Action a)
            {
                while (true)
                {
                    a?.Invoke();
                    Ticks++;
                    yield return TimeoutForAction > 0 ? new WaitTime(TimeoutForAction) : null;
                }
            }

            Name = name ?? RandomString();
            _enumerator = CoroutineAction(action);
        }


        public Coroutine(IEnumerator enumerator, string owner, string name = null, bool autoStart = true)
        {
            DoWork = autoStart;
            Started = DateTime.Now;
            TimeoutForAction = -1;
            Name = name ?? RandomString();
            Owner = owner;
            _enumerator = enumerator;
        }

        public IEnumerator Wait()
        {
            while (!IsDone)
            {
                yield return null;
            }
        }

        public Coroutine GetCopy(Coroutine cor)
        {
            if (cor.ThisIsSimple)
            {
                return (new Coroutine(cor.Action, cor.TimeoutForAction, cor.Owner, cor.Name, cor.DoWork)
                    {Priority = cor.Priority, AutoResume = cor.AutoResume, DoWork = cor.DoWork});
            }
            return (new Coroutine(cor.GetEnumerator(), cor.Owner, cor.Name, cor.DoWork)
                {Priority = cor.Priority, AutoResume = cor.AutoResume, DoWork = cor.DoWork});
        }

        public IEnumerator GetEnumerator() => _enumerator;
        public void UpdateTicks(int tick) => Ticks = tick;
        public void Resume() => DoWork = true;

        public void Pause(bool force = false)
        {
            if (Priority == CoroutinePriority.Critical && !force) return;
            DoWork = false;
        }

        public bool Done()
        {
            if (Priority == CoroutinePriority.Critical) return false;
            return IsDone = true;
        }

        public bool MoveNext() => MoveNext(_enumerator);

        private bool MoveNext(IEnumerator enumerator) =>
            !IsDone && (enumerator.Current is IEnumerator e && MoveNext(e) || enumerator.MoveNext());


        public string RandomString()
        {
            int size = 16;
            return Guid.NewGuid().ToString().Substring(0, size).Replace("-", String.Empty);
        }
    }


    public class WaitRender : YieldBase
    {
        private long _howManyRenderCountWait;

        public WaitRender(long howManyRenderCountWait = 1)
        {
            _howManyRenderCountWait = howManyRenderCountWait;
            Current = GetEnumerator();
        }

        public sealed override IEnumerator GetEnumerator()
        {
            var prevRenderCount = GameController.Instance.RenderCount;
            _howManyRenderCountWait += GameController.Instance.RenderCount;
            while (prevRenderCount < _howManyRenderCountWait)
            {
                prevRenderCount = GameController.Instance.RenderCount;
                yield return null;
            }
        }
    }

    public class WaitFunction : YieldBase
    {
        public WaitFunction(Func<bool> fn)
        {
            while (fn())
            {
                Current = GetEnumerator();
            }
        }

        public sealed override IEnumerator GetEnumerator()
        {
            yield return null;
        }
    }

    public class WaitTime : YieldBase
    {
        private readonly int _milliseconds;


        public WaitTime(int milliseconds)
        {
            _milliseconds = milliseconds;
            Current = GetEnumerator();
        }

        public sealed override IEnumerator GetEnumerator()
        {
            var waiter = GameController.Instance.MainTimer.ElapsedMilliseconds + _milliseconds;
            while (GameController.Instance.MainTimer.ElapsedMilliseconds < waiter)
            {
                yield return null;
            }
        }
    }

    public abstract class YieldBase : IEnumerable
    {
        public object Current { get; protected set; }

        public virtual IEnumerator GetEnumerator()
        {
            return (IEnumerator) Current;
        }
    }

    public enum CoroutinePriority
    {
        Normal,
        High,
        Critical
    }
}
