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
        public Action Action { get; private set; } = null;

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
                    yield return TimeoutForAction > 0 ? new WaitTime(TimeoutForAction) : new YieldBase();
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
            byte[] data = new byte[size];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetBytes(data);
            return BitConverter.ToString(data).Replace("-", String.Empty);
        }
    }


    public class WaitRender : YieldBase
    {
        public WaitRender(long howManyRenderCountWait = 1)
        {
            Current = WR(howManyRenderCountWait);
        }

        IEnumerator WR(long howManyRenderCountWait)
        {
            var prevRenderCount = GameController.Instance.RenderCount;
            howManyRenderCountWait += GameController.Instance.RenderCount;
            while (prevRenderCount < howManyRenderCountWait)
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
                Current = Wf();
            }

            IEnumerator Wf()
            {
                yield return null;
            }
        }
    }

    public class WaitTime : YieldBase
    {
        public WaitTime(int milliseconds)
        {
            Current = WaitMs(milliseconds);
        }


        IEnumerator WaitMs(int ms)
        {
            var waiter = GameController.Instance.mainSw.ElapsedMilliseconds + ms;
            while (GameController.Instance.mainSw.ElapsedMilliseconds < waiter)
            {
                yield return null;
            }
        }
    }

    public class YieldBase : IEnumerator
    {
        public bool MoveNext()
        {
            return Current != null && ((IEnumerator) Current).MoveNext();
        }

        public void Reset()
        {
            ((IEnumerator) Current)?.Reset();
        }

        public object Current { get; protected set; }
    }

    public enum CoroutinePriority
    {
        Normal,
        High,
        Critical
    }
}
