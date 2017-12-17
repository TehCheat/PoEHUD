using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PoeHUD.Framework.Tools
{
    public static class Scrambler
    {
        private static readonly Func<string, bool> Invalid = name =>
        {
            string[] names = { "calculator.exe", "poehud.exe", "exilehud.exe", "exilebuddy.exe" };
            return names.Any(str => string.Equals(str, name, StringComparison.CurrentCultureIgnoreCase));
        };

        private static readonly Action<string> ShowError = message =>
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        };

        public static bool Scramble(string parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter))
            {
                bool result = true;
                try
                {
                    string srcPath = Assembly.GetEntryAssembly().Location;

                    if (Invalid(Path.GetFileName(srcPath)) || new FileInfo(srcPath).CreationTimeUtc < DateTime.UtcNow.AddDays(-0.5))
                    {
                        string dstPath = EncryptFile(srcPath);
                        File.Delete(@"PoeHUD");
                        Process.Start("cmd.exe", $"/c  mklink PoeHUD \"{dstPath}\"");
                        Process.Start(dstPath, $"\"{srcPath}\"");
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch (Exception e)
                {
                    ShowError($"Failed to encrypt a file: {e.Message}");
                }

                return result;
            }

            try
            {
                File.Delete(parameter);
            }
            catch (Exception e)
            {
                string srcPath = Path.GetFileName(parameter);
                ShowError($"Failed to delete {srcPath}, {e.Message}");
            }

            return false;
        }

        private static string EncryptFile(string srcPath)
        {
            byte[] fileData = File.ReadAllBytes(srcPath);
            byte[] csum = Generators.GenerateCryptoSum(4);
            Buffer.BlockCopy(csum, 0, fileData, 0x12, csum.Length);
            string dstFileName = Generators.GenerateName(3, 12, Invalid);
            string dstPath = Path.Combine(Path.GetDirectoryName(srcPath), dstFileName);
            File.WriteAllBytes(dstPath, fileData);
            return dstPath;
        }
    }
}
