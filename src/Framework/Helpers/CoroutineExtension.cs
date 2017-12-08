using System.Collections;
using PoeHUD.Controllers;

namespace PoeHUD.Framework.Helpers
{
    public static class CoroutineExtension
    {
        public static Coroutine Run(this Coroutine coroutine) => GameController.Instance.CoroutineRunner.Run(coroutine);

        public static Coroutine Run(this IEnumerator iEnumeratorCor,string owner, string name =null) => GameController.Instance.CoroutineRunner.Run(iEnumeratorCor,owner,name);

        public static Coroutine GetCopy(this Coroutine coroutine) => coroutine.GetCopy(coroutine);

        public static Coroutine AutoRestart(this Coroutine coroutine, Runner runner)
        {
            runner.AddToAutoupdate(coroutine);
            return coroutine;
        }


        public static Coroutine RunParallel(this Coroutine coroutine) =>
            GameController.Instance.CoroutineRunnerParallel.Run(coroutine);

        public static Coroutine RunParallel(this IEnumerator iEnumeratorCor, string owner, string name = null) =>
            GameController.Instance.CoroutineRunnerParallel.Run(iEnumeratorCor, owner, name);


    }
}