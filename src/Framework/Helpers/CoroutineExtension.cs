using System.Collections;
using PoeHUD.Controllers;

namespace PoeHUD.Framework.Helpers
{
    public static class CoroutineExtension
    {
        public static Coroutine Run(this Coroutine coroutine) => GameController.Instance.CoroutineRunner.Run(coroutine);

        public static Coroutine Run(this IEnumerator iEnumeratorCor, string owner, string name = null) => GameController.Instance.CoroutineRunner.Run(iEnumeratorCor, owner, name);

        public static bool Done(this Coroutine coroutine) => GameController.Instance.CoroutineRunner.Done(coroutine);

        public static Coroutine GetCopy(this Coroutine coroutine) => coroutine.GetCopy(coroutine);

        public static Coroutine AutoRestart(this Coroutine coroutine)
        {
            GameController.Instance.CoroutineRunner.AddToAutoupdate(coroutine);
            return coroutine;
        }
    }
}