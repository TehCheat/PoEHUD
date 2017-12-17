using System;
using System.Linq;
using System.Security.Cryptography;

namespace PoeHUD.Framework.Tools
{
    public static class Generators
    {
        private const string Table = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly Random Randomizer = new Random();

        public static string GenerateName(int min, int max, Func<string, bool> invalid)
        {
            while (true)
            {
                string value = new string(Enumerable.Repeat(Table, max)
                    .Select(s => s[Randomizer.Next(s.Length)])
                    .ToArray()).Substring(0, Randomizer.Next(min, max));

                string name = value + ".exe";
                if (invalid(name))
                {
                    GenerateName(min, max, invalid);
                }

                return name;
            }
        }

        public static byte[] GenerateCryptoSum(int size)
        {
            byte[] cryptoSum = new byte[size];
            using (RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(cryptoSum);
            }

            return cryptoSum;
        }
    }
}
