using PoeHUD.Framework.Enums;
using PoeHUD.Models;
using PoeHUD.Poe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Controllers;
using System.Runtime.InteropServices;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Framework
{
    public class Memory : IDisposable
    {
        public readonly long AddressOfProcess;
        private readonly Dictionary<string, int> modules;
        private bool closed;
        public Offsets offsets;
        public IntPtr procHandle;

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

        public ushort ReadUShort(long addr)
        {
            return BitConverter.ToUInt16(ReadMem(addr, 2), 0);
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

        public string ReadNativeString(long addr) => NativeStringReader.ReadString(addr);

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

        public byte ReadByte(long addr, params long[] offsets)
        {
            //Simple for better then LINQ for often operation
            long num = ReadLong(addr);
            long result = num;
            for (var index = 0; index < offsets.Length; index++)
            {
                var offset = offsets[index];

                if(index < offsets.Length - 1)
                    result = ReadLong(result + offset);
                else
                    result = ReadByte(result + offset);
            }
            return (byte)result;
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

        //I hope in future all of this next shit will be replaced with GrayMagic:
        public List<T> ReadStructsArray<T>(long startAddress, long endAddress, int structSize, int maxCountLimit) where T : RemoteMemoryObject, new()
        {
            var result = new List<T>();
            var range = endAddress - startAddress;
            if (range < 0 || range / structSize > maxCountLimit)
            {
                if(PoeHUD.Hud.MainMenuWindow.Settings.DeveloperMode.Value)
                    DebugPlug.DebugPlugin.LogMsg($"Fixed possible memory leak while reading array of struct '{typeof(T).Name}'", 1, SharpDX.Color.Yellow);
                return result;
            }

            for (var address = startAddress; address < endAddress; address += structSize)
                result.Add(GameController.Instance.Game.GetObject<T>(address));
            return result;
        }

        public List<T> ReadDoublePtrVectorClasses<T>(long address, bool noNullPointers = false) where T : RemoteMemoryObject, new()
        {
            var start = ReadLong(address);
            //var end = ReadLong(address + 0x8);
            var last = ReadLong(address + 0x10);

            var length = (int)(last - start);
            var bytes = ReadBytes(start, length);

            var result = new List<T>();
            for (int readOffset = 0; readOffset < length; readOffset += 16)
            {
                var pointer = BitConverter.ToInt64(bytes, readOffset);
                if (pointer == 0 && noNullPointers)
                    continue;
                result.Add(GameController.Instance.Game.GetObject<T>(pointer));
            }
            return result;
        }

        public List<long> ReadPointersArray(long startAddress, long endAddress, int offset = 8)
        {
            var result = new List<long>();
            for (var address = startAddress; address < endAddress; address += offset)
                result.Add(ReadLong(address));
            return result;
        }

        public List<long> ReadSecondPointerArray_Count(long startAddress, int count)
        {
            var result = new List<long>();
            startAddress += 8;//Skip first

            for (int i = 0; i < count; i++)
            {
                result.Add(ReadLong(startAddress));
                startAddress += 16;
            }
            return result;
        }

        public T IntptrToStruct<T>(long pointer, int structSize) where T : struct
        {
            var bytes = ReadBytes(pointer, structSize);
            return IntptrToStruct<T>(bytes);
        }

        public T IntptrToStruct<T>(byte[] data) where T : struct
        {
            GCHandle gch = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(gch.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                gch.Free();
            }
        }

        #region Special Structs reading

        //Temporary for reading QustStates
        //Hope some day this will be replaced with GrayMagic dll to read generic structs https://github.com/Konctantin/GreyMagic
        public List<Tuple<long, int>> ReadDoublePointerIntList(long address) 
        {
            var list = new List<Tuple<long, int>>();
            var head = ReadLong(address + 0x8);
            ListDoublePointerIntNode node = ReadDoublePointerIntListNode(head);
            list.Add(new Tuple<long, int>(node.Ptr2_Key, node.Value));

            for (var ptr2 = node.NextPtr; ptr2 != head; ptr2 = node.NextPtr)
            {
                node = ReadDoublePointerIntListNode(ptr2);

                list.Add(new Tuple<long, int>(node.Ptr2_Key, node.Value));
            }
            if (list.Count > 0)
                list.RemoveAt(list.Count - 1);//bug fix, useless reading last element
            return list;
        }
        private unsafe ListDoublePointerIntNode ReadDoublePointerIntListNode(long pointer)
        {
            int objSize = Marshal.SizeOf(typeof(ListDoublePointerIntNode));
            var bytes = ReadBytes(pointer, objSize);

            ListDoublePointerIntNode str;
            fixed (byte* fixedBytes = &bytes[0])
            {
                str = *(ListDoublePointerIntNode*)fixedBytes;
            }
            return str;
        }

        //DoublePointer as key + intValue as value
        public struct ListDoublePointerIntNode
        {
            public long PreviousPtr;
            public long NextPtr;

            //Double vector struct:
            public long Ptr1_Unused;
            public long Ptr2_Key;

            public int Value;
        }




        /*
        public Dictionary<TKey, TValue> ReadHashMap<TKey, TValue>(long pointer) where TKey : struct where TValue : struct
        {
            var result = new Dictionary<TKey, TValue>();

            Stack<HashNode<TKey, TValue>> stack = new Stack<HashNode<TKey, TValue>>();
            var startNode = IntptrToStruct<HashNode<TKey, TValue>>(pointer, 0x30);
            var item = IntptrToStruct<HashNode<TKey, TValue>>(startNode.Root, 0x30);
            stack.Push(item);

            while (stack.Count != 0)
            {
                HashNode<TKey, TValue> node3 = stack.Pop();
                if (node3.IsNull == 0)
                    result.Add(node3.Key, node3.Value);

                HashNode<TKey, TValue> node4 = IntptrToStruct<HashNode<TKey, TValue>>(node3.Previous, 0x30);
                if (node4.IsNull == 0)
                    stack.Push(node4);

                HashNode<TKey, TValue> node5 = IntptrToStruct<HashNode<TKey, TValue>>(node3.Next, 0x30);
                if (node5.IsNull == 0)
                    stack.Push(node5);
            }
            return result;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct HashNode<TNodeKey, TNodeValue> where TNodeKey : struct where TNodeValue : struct
        {
            public readonly long Previous;
            public readonly long Root;
            public readonly long Next;
            public readonly byte Unknown;
            public readonly byte IsNull;
            private readonly byte byte_0;
            private readonly byte byte_1;
            public readonly TNodeKey Key;
            public readonly TNodeValue Value;
        }
        */
        /*
        public unsafe T IntptrToStruct<T>(byte[] bytes) where T : struct
        {
            fixed (byte* ptr = bytes)
            {
                return *(T*)ptr;
            }
        }
        */
        #endregion

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
