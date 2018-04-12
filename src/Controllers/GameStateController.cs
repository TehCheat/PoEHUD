using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PoeHUD.DebugPlug;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Performance;
using PoeHUD.Hud.Settings;
using PoeHUD.Models;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class GameStateController : RemoteMemoryObject
    {
        public GameStateController(Memory m, TheGame game)
        {
            Game = game;
            M = m;
            Instance = this;
            Address = m.ReadLong(Offsets.GameStateOffset + m.AddressOfProcess);

            AllGameStates = ReadHashMap(Address + 0x48);

            PreGameStatePtr = AllGameStates["PreGameState"].Address;
            LoginStatePtr = AllGameStates["LoginState"].Address;
            SelectCharacterStatePtr = AllGameStates["SelectCharacterState"].Address;
            WaitingStatePtr = AllGameStates["WaitingState"].Address;
            InGameStatePtr = AllGameStates["InGameState"].Address;
            LoadingState = AllGameStates["AreaLoadingState"].AsObject<AreaLoadingState>();
            IngameState = AllGameStates["InGameState"].AsObject<IngameState>();
        }

        //I hope this caching will works fine
        private static long PreGameStatePtr = -1;
        private static long LoginStatePtr = -1;
        private static long SelectCharacterStatePtr = -1;
        private static long WaitingStatePtr = -1;
        private static long InGameStatePtr = -1;
        private static GameStateController Instance;

        public readonly Dictionary<string, GameState> AllGameStates;
        public static AreaLoadingState LoadingState { get; private set; }
        public static IngameState IngameState { get; private set; }
        public static List<GameState> CurrentGameStates => Instance.M.ReadDoublePtrVectorClasses<GameState>(Instance.Address + 0x8);
        public static List<GameState> ActiveGameStates => Instance.M.ReadDoublePtrVectorClasses<GameState>(Instance.Address + 0x20, true);

        public static bool IsPreGame => GameStateActive(PreGameStatePtr);
        public static bool IsLoginState => GameStateActive(LoginStatePtr);
        public static bool IsSelectCharacterState => GameStateActive(SelectCharacterStatePtr);
        public static bool IsWaitingState => GameStateActive(WaitingStatePtr);//This happens after selecting character, maybe other cases
        public static bool IsInGameState => GameStateActive(InGameStatePtr);//In game, with selected character
        public static bool IsLoading => LoadingState.IsLoading;

        private static bool GameStateActive(long stateAddress)
        {
            var M = GameController.Instance.Memory;
            var address = Instance.Address + 0x20;
            var start = M.ReadLong(address);
            //var end = ReadLong(address + 0x8);
            var last = M.ReadLong(address + 0x10);

            var length = (int)(last - start);
            var bytes = M.ReadBytes(start, length);

            for (int readOffset = 0; readOffset < length; readOffset += 16)
            {
                var pointer = BitConverter.ToInt64(bytes, readOffset);
                if (stateAddress == pointer) return true;
            }
            return false;
        }

        private Dictionary<string, GameState> ReadHashMap(long pointer)
        {
            var result = new Dictionary<string, GameState>();

            Stack<GameStateHashNode> stack = new Stack<GameStateHashNode>();
            var startNode = ReadObject<GameStateHashNode>(pointer);
            var item = startNode.Root;
            stack.Push(item);

            while (stack.Count != 0)
            {
                GameStateHashNode node = stack.Pop();
                if (!node.IsNull)
                    result.Add(node.Key, node.Value1);

                GameStateHashNode prev = node.Previous;
                if (!prev.IsNull)
                    stack.Push(prev);

                GameStateHashNode next = node.Next;
                if (!next.IsNull)
                    stack.Push(next);
            }
            return result;
        }
        private class GameStateHashNode : RemoteMemoryObject
        {
            public GameStateHashNode Previous => ReadObject<GameStateHashNode>(Address);
            public GameStateHashNode Root => ReadObject<GameStateHashNode>(Address + 0x8);
            public GameStateHashNode Next => ReadObject<GameStateHashNode>(Address + 0x10);
            //public readonly byte Unknown;
            public bool IsNull => M.ReadByte(Address + 0x19) != 0;
            //private readonly byte byte_0;
            //private readonly byte byte_1;
            public string Key => M.ReadNativeString(Address + 0x20);
            //public readonly int Useless;
            public GameState Value1 => ReadObject<GameState>(Address + 0x40);
            //public readonly long Value2;
        }
    }

    public class GameState : RemoteMemoryObject
    {
        private string stateName;
        public string StateName => stateName != null ? stateName :
            stateName = M.ReadNativeString(Address + 0x10);

        public override string ToString()
        {
            return StateName;
        }
    }

    public class AreaLoadingState : GameState
    {
        //This is actualy pointer to loading screen stuff (image, etc), but should works fine.
        public bool IsLoading => M.ReadLong(Address + 0xBD0) != 0;
        public string AreaName => M.ReadString(Address + 0xBE8);

        public override string ToString()
        {
            return $"{AreaName}, IsLoading: {IsLoading}";
        }
    }
}