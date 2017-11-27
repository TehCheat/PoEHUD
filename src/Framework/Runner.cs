using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PoeHUD.Framework
{
    public class Runner
    {
        readonly List<Coroutine> _coroutines = new List<Coroutine>();

        readonly List<(string name, string owner, long ticks, DateTime end, DateTime start)> _finishedCoroutines =
            new List<(string name, string owner, long ticks, DateTime end, DateTime start)>();

        public bool IsRunning => _coroutines.Count > 0;

        public IEnumerable<(string Name, string Owner, long Ticks, DateTime End, DateTime Started)>
            FinishedCoroutines => _finishedCoroutines;

        public int FinishedCoroutineCount { get; private set; }
        public IEnumerable<Coroutine> Coroutines => _coroutines;
        public IEnumerable<Coroutine> WorkingCoroutines => _coroutines.Where(x => x.DoWork);
        private readonly HashSet<Coroutine> _autorestartCoroutines = new HashSet<Coroutine>();
        public IEnumerable<Coroutine> AutorestartCoroutines => _autorestartCoroutines;
        public Coroutine GetCoroutineByname(string name) => _coroutines.FirstOrDefault(x => x.Name.Contains(name));
        public int CountAddCoroutines { get; private set; }
        public int CountFalseAddCoroutines { get; private set; }
        public int RunPerLoopIter { get; set; } = 3;

        public Coroutine Run(IEnumerator enumerator, string owner, string name = null)
        {
            var routine = new Coroutine(enumerator, owner, name);

            var first = _coroutines.FirstOrDefault(x => x.Name == routine.Name && x.Owner == routine.Owner);
            if (first != null)
            {
                CountFalseAddCoroutines++;
                return first;
            }
            _coroutines.Add(routine);
            CountAddCoroutines++;
            return routine;
        }

        public Coroutine Run(Coroutine routine)
        {
            var first = _coroutines.FirstOrDefault(x => x.Name == routine.Name && x.Owner == routine.Owner);
            if (first != null)
            {
                CountFalseAddCoroutines++;
                return first;
            }
            _coroutines.Add(routine);
            CountAddCoroutines++;
            return routine;
        }


        public void StopCoroutines(IEnumerable<Coroutine> coroutines)
        {
            foreach (var coroutine in coroutines)
                coroutine.Pause();
        }

        public void ResumeCoroutines(IEnumerable<Coroutine> coroutines)
        {
            foreach (var coroutine in coroutines)
                if (coroutine.AutoResume)
                    coroutine.Resume();
        }

        public bool HasName(string name) => _coroutines.Any(x => x.Name == name);

        public int Count => _coroutines.Count;

        public bool Done(Coroutine coroutine) =>
            coroutine.Priority != CoroutinePriority.Critical && coroutine.Priority != CoroutinePriority.High &&
            coroutine.Done();

        public bool Update()
        {
            if (_coroutines.Count > 0)
            {
                for (var i = 0; i < _coroutines.Count; i++)
                {
                    if (_coroutines[i] != null && !_coroutines[i].IsDone)
                    {
                        if (_coroutines[i].DoWork)
                        {
                            if (_coroutines[i].MoveNext()) continue;
                            _coroutines[i].Done();
                        }
                    }
                    else
                    {
                        if (_coroutines[i] != null)
                        {
                            _finishedCoroutines.Add(
                                (_coroutines[i].Name, _coroutines[i].Owner, _coroutines[i].Ticks, DateTime.Now,
                                _coroutines[i].Started));
                            FinishedCoroutineCount++;
                        }
                        _coroutines.RemoveAt(i);
                    }
                }
                return true;
            }
            return false;
        }

        public void AddToAutoupdate(Coroutine coroutine)
        {
            _autorestartCoroutines.Add(coroutine.GetCopy(coroutine));
        }
    }
}