using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SharpDX;

namespace PoeHUD.Framework
{
    public class Runner
    {
        public string Name { get; }

        readonly List<Coroutine> _coroutines = new List<Coroutine>();
        readonly  List<Tuple<string,string,long,DateTime,DateTime>> _finishedCoroutines = new List<Tuple<string, string, long, DateTime, DateTime>>();
        public bool IsRunning => _coroutines.Count > 0;

        public IEnumerable<Tuple<string,string,long,DateTime,DateTime>>
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

        public Runner(string name)
        {
            Name = name;
        }
        public Coroutine Run(IEnumerator enumerator, string owner, string name =null)
        {
            var routine = new Coroutine(enumerator,owner,name);
            
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
                            try
                            {
                                if (_coroutines[i].MoveNext()) continue;
                                _coroutines[i].Done();
                            }
                            catch (Exception e) { DebugPlug.DebugPlugin.LogMsg($"Coroutine {_coroutines[i].Name} error: {e}", 10, Color.Red); }
                        }
                            
                    }
                    else
                    {
                        if (_coroutines[i] != null)
                        {
                            _finishedCoroutines.Add(new Tuple<string, string, long, DateTime, DateTime>(_coroutines[i].Name,_coroutines[i].Owner,_coroutines[i].Ticks,_coroutines[i].Started,DateTime.Now));
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