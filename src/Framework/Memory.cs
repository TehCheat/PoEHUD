using PoeHUD.Framework.Enums;
using PoeHUD.Models;
using PoeHUD.Poe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Framework
{
    public class Memory : IDisposable
    {
        public readonly long AddressOfProcess;
        private readonly Dictionary<string, int> modules;
        private bool closed;
        public Offsets offsets;
        private IntPtr procHandle;

        public Memory(Offsets offs, int pId)
        {
            try
            {
                offsets = offs;
                Process = Process.GetProcessById(pId);
                AddressOfProcess = Process.MainModule.BaseAddress.ToInt64();
                procHandle = WinApi.OpenProcess(Process, ProcessAccessFlags.All);
                modules = new Dictionary<string, int>();
            }
            catch (Win32Exception ex)
            {
                throw new Exception("You should run program as an administrator", ex);
            }
        }

        public Process Process { get; }

        public void Dispose()
        {
            Close();
        }

        ~Memory()
        {
            Close();
        }

        public int GetModule(string name)
        {
            if (modules.ContainsKey(name))
            {
                return modules[name];
            }
            int num = Process.Modules.Cast<ProcessModule>().First(m => m.ModuleName == name).BaseAddress.ToInt32();
            modules.Add(name, num);
            return num;
        }

        public bool IsInvalid()
        {
            return Process.HasExited || closed;
        }

        public int ReadInt(long addr)
        {
            return BitConverter.ToInt32(ReadMem(addr, 4), 0);
        }

        public int ReadInt(int addr, params int[] offsets)
        {
            //Simple for better then LINQ for often operation
            int num = ReadInt(addr);
            int result = num;
            for (var index = 0; index < offsets.Length; index++)
            {
                var offset = offsets[index];
                result = ReadInt(result + offset);
            }
            return result;
        }

        public int ReadInt(long addr, params long[] offsets)
        {
            //Simple for better then LINQ for often operation
            long num = ReadLong(addr);
            long result = num;
            for (var index = 0; index < offsets.Length; index++)
            {
                var offset = offsets[index];
                result = ReadLong(result + offset);
            }
            return (int)result;
        }

      


        public float ReadFloat(long addr)
        {
            return BitConverter.ToSingle(ReadMem(addr, 4), 0);
        }

        public long ReadLong(long addr)
        {
            return BitConverter.ToInt64(ReadMem(addr, 8), 0);
        }

        public long ReadLong(long addr, params long[] offsets)
        {
            //Simple for better then LINQ for often operation
            long num = ReadLong(addr);
            long result = num;
            for (var index = 0; index < offsets.Length; index++)
            {
                var offset = offsets[index];
                result = ReadLong(result + offset);
            }
            return result;
        }

        public uint ReadUInt(long addr)
        {
            return BitConverter.ToUInt32(ReadMem(addr, 4), 0);
        }


        /// <summary>
        /// Read string as ASCII
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="length"></param>
        /// <param name="replaceNull"></param>
        /// <returns></returns>
        public string ReadString(long addr, int length = 256, bool replaceNull = true)
        {
            if (addr <= 65536 && addr >= -1)
            {
                return string.Empty;
            }
            string @string = Encoding.ASCII.GetString(ReadMem(addr, length));
            return replaceNull ? RTrimNull(@string) : @string;
        }

        private static string RTrimNull(string text)
        {
            int num = text.IndexOf('\0');
            return num > 0 ? text.Substring(0, num) : text;
        }

        /// <summary>
        /// Read string as Unicode
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="length"></param>
        /// <param name="replaceNull"></param>
        /// <returns></returns>
        public string ReadStringU(long addr, int length = 256, bool replaceNull = true)
        {
            if (addr <= 65536 && addr >= -1)
            {
                return string.Empty;
            }
            byte[] mem = ReadMem(addr, length);
            if (mem.Length == 0)
            {
                return String.Empty;
            }
            if (mem[0] == 0 && mem[1] == 0)
                return string.Empty;
            string @string = Encoding.Unicode.GetString(mem);
            return replaceNull ? RTrimNull(@string) : @string;
        }

        public byte ReadByte(long addr)
        {
            return ReadBytes(addr, 1).FirstOrDefault();
        }

        public byte[] ReadBytes(long addr, int length)
        {
            return ReadMem(addr, length);
        }

        private void Close()
        {
            if (!closed)
            {
                closed = true;
                WinApi.CloseHandle(procHandle);
            }
        }

        private byte[] ReadMem(long addr, int size)
        {
            var array = new byte[size];
            WinApi.ReadProcessMemory(procHandle, (IntPtr)addr, array);
            return array;
        }

        public string DebugStr = "";
        public long[] FindPatterns(params Pattern[] patterns)
        {
            byte[] exeImage = ReadBytes(AddressOfProcess, 0x2000000); //33mb
            var address = new long[patterns.Length];
            //Little faster start hud
            //For me ~1400 vs ~800ms
            Parallel.For(0, patterns.Length, iPattern =>
            {
                Pattern pattern = patterns[iPattern];
                byte[] patternData = pattern.Bytes;
                int patternLength = patternData.Length;

                bool found = false;

                for (int offset = 0; offset < exeImage.Length - patternLength; offset ++)
                {
                    if (CompareData(pattern, exeImage, offset))
                    {
                        found = true;
                        address[iPattern] = offset;
                        DebugStr += "Pattern " + iPattern + " is found at " + (AddressOfProcess + offset).ToString("X") + " offset: " + offset.ToString("X") + Environment.NewLine;
                        break;
                    }
                }

                if(!found)
                {
                    //System.Windows.Forms.MessageBox.Show("Pattern " + iPattern + " is not found!");
                    DebugStr += "Pattern " + iPattern + " is not found!" + Environment.NewLine;
                }
            });
            return address;
        }

        private bool CompareData(Pattern pattern, byte[] data, int offset)
        {
            //Better than linq for me ~700ms vs ~60ms
            bool any = false;
            for (int i = 0; i < pattern.Bytes.Length; i++)
                if (pattern.Mask[i] == 'x' && pattern.Bytes[i] != data[offset + i])
                {
                    any = true;
                    break;
                }
            return !any;
        }
    }
}
