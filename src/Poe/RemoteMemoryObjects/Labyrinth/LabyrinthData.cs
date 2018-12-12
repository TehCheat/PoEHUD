using System;
using System.Linq;
using System.Text;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using System.Collections.Generic;
using PoeHUD.Framework;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    /// <summary>
    /// We going to read all information here to get all data cached
    /// </summary>
    public class LabyrinthData : RemoteMemoryObject
    {
        public List<LabyrinthRoom> Rooms
        {
            get
            {
                var firstPtr = M.ReadLong(Address);
                var lastPtr = M.ReadLong(Address + 0x8);

                var result = new List<LabyrinthRoom>();
                CachedRoomsDictionary = new Dictionary<long, LabyrinthRoom>();

                int roomIndex = 0;
                for (var addr = firstPtr; addr < lastPtr; addr += 0x60)
                {
                    //DebugPlug.DebugPlugin.LogMsg($"Room {roomIndex} Addr: {addr.ToString("x")}", 0);
                    if (addr == 0) continue;
                    var room = new LabyrinthRoom(M, addr);
                    room.Id = roomIndex++;
                    result.Add(room);
                    CachedRoomsDictionary.Add(addr, room);
                }
                
                return result;
            }
        }

        //we gonna use this to have identical references to rooms
        internal static Dictionary<long, LabyrinthRoom> CachedRoomsDictionary;

        internal static LabyrinthRoom GetRoomById(long roomId)
        {
            LabyrinthRoom room;
            CachedRoomsDictionary.TryGetValue(roomId, out room);
            return room;
        }
    }

    public class LabyrinthRoom
    {
        private long Address;
        public int Id { get; internal set; }
        private Memory M;
        public LabyrinthSecret Secret1 { get; internal set; }
        public LabyrinthSecret Secret2 { get; internal set; }
        public LabyrinthRoom[] Connections { get; internal set; }   // Length is always 5
        public LabyrinthSection Section { get; internal set; }
        

        internal LabyrinthRoom(Memory m, long address)
        {
            M = m;
            Address = address;
            Secret1 = ReadSecret(M.ReadLong(Address + 0x40));
            Secret2 = ReadSecret(M.ReadLong(Address + 0x50));
            Section = ReadSection(M.ReadLong(Address + 0x30));

            var roomsPointers = M.ReadPointersArray(Address, Address + 0x20);
            Connections = roomsPointers.Select(x => x == 0 ? null : LabyrinthData.GetRoomById(x)).ToArray();
        }

        internal LabyrinthSection ReadSection(long addr)
        {
            if (addr == 0) return null;//Should never happens
            var section = new LabyrinthSection(M, addr);
          

            return section;
        }

        private LabyrinthSecret ReadSecret(long addr)
        {
            var secretAddress = M.ReadLong(addr);
            if (addr == 0) return null;

            var result = new LabyrinthSecret();
            result.SecretName = M.ReadStringU(M.ReadLong(addr));
            result.Name = M.ReadStringU(M.ReadLong(addr + 0x8));

            return result;
        }

        public override string ToString()
        {
            var linked = "";

            var realConnections = Connections.Where(r => r != null).ToList();
            if (realConnections.Count > 0)
            {
                linked = $"LinkedWith: {string.Join(", ", realConnections.Select(x => x.Id.ToString()).ToArray())}";
            }

            return $"Id: {Id}, " +
                $"Secret1: {(Secret1 == null ? "None" : Secret1.SecretName)}, Secret2: {(Secret2 == null ? "None" : Secret2.SecretName)}, {linked}, Section: {Section}";
        }


        public class LabyrinthSecret
        {
            public string SecretName { get; internal set; }
            public string Name { get; internal set; }

            public override string ToString()
            {
                return SecretName;
            }
        }

        public class LabyrinthSection
        {
            public string SectionType { get; internal set; }
            public List<LabyrinthSectionOverrides> Overrides { get; internal set; }  = new List<LabyrinthSectionOverrides>();
            public LabyrinthSectionAreas SectionAreas { get; internal set; }

            internal LabyrinthSection(Memory M, long addr)
            {
                SectionType = M.ReadStringU(M.ReadLong(addr + 0x8, 0));

                var overridesCount = M.ReadInt(addr + 0x5c);
                var overridesArrayPtr = M.ReadLong(addr + 0x64);

                var overridePointers = M.ReadSecondPointerArray_Count(overridesArrayPtr, overridesCount);

                for (int i = 0; i < overridesCount; i++)
                {
                    var newOverride = new LabyrinthSectionOverrides();
                    var overrideAddr = overridePointers[i];
                    newOverride.OverrideName = M.ReadStringU(M.ReadLong(overrideAddr));
                    newOverride.Name = M.ReadStringU(M.ReadLong(overrideAddr + 0x8));
                    Overrides.Add(newOverride);
                }

                SectionAreas = new LabyrinthSectionAreas();
                var areasPtr = M.ReadLong(addr + 0x4c);
                SectionAreas.Name = M.ReadStringU(M.ReadLong(areasPtr));

                var normalCount = M.ReadInt(areasPtr + 0x8);
                var normalArrayPtr = M.ReadLong(areasPtr + 0x10);
                SectionAreas.NormalAreasPtrs = M.ReadSecondPointerArray_Count(normalArrayPtr, normalCount);

                var cruelCount = M.ReadInt(areasPtr + 0x18);
                var cruelArrayPtr = M.ReadLong(areasPtr + 0x20);
                SectionAreas.CruelAreasPtrs = M.ReadSecondPointerArray_Count(cruelArrayPtr, cruelCount);

                var mercCount = M.ReadInt(areasPtr + 0x28);
                var mercArrayPtr = M.ReadLong(areasPtr + 0x30);
                SectionAreas.MercilesAreasPtrs = M.ReadSecondPointerArray_Count(mercArrayPtr, mercCount);

                var endgameCount = M.ReadInt(areasPtr + 0x38);
                var endgameArrayPtr = M.ReadLong(areasPtr + 0x40);
                SectionAreas.EndgameAreasPtrs = M.ReadSecondPointerArray_Count(endgameArrayPtr, endgameCount);
            }


            public override string ToString()
            {
                var overrides = "";

                if (Overrides.Count > 0)
                    overrides = $"Overrides: {string.Join(", ", Overrides.Select(x => x.ToString()).ToArray())}";

                return $"SectionType: {SectionType}, {overrides}";
            }
        }

        public class LabyrinthSectionAreas
        {
            public string Name { get; internal set; }
            internal List<long> NormalAreasPtrs = new List<long>();
            internal List<long> CruelAreasPtrs = new List<long>();
            internal List<long> MercilesAreasPtrs = new List<long>();
            internal List<long> EndgameAreasPtrs = new List<long>();

            private List<WorldArea> normalAreas;
            public List<WorldArea> NormalAreas
            {
                get
                {
                    if (normalAreas == null)
                        normalAreas = NormalAreasPtrs.Select(x => GameController.Instance.Files.WorldAreas.GetByAddress(x)).ToList();
                    return normalAreas;
                }
            }

            private List<WorldArea> cruelAreas;
            public List<WorldArea> CruelAreas
            {
                get
                {
                    if (cruelAreas == null)
                        cruelAreas = CruelAreasPtrs.Select(x => GameController.Instance.Files.WorldAreas.GetByAddress(x)).ToList();
                    return cruelAreas;
                }
            }

            private List<WorldArea> mercilesAreas;
            public List<WorldArea> MercilesAreas
            {
                get
                {
                    if (mercilesAreas == null)
                        mercilesAreas = MercilesAreasPtrs.Select(x => GameController.Instance.Files.WorldAreas.GetByAddress(x)).ToList();
                    return mercilesAreas;
                }
            }

            private List<WorldArea> endgameAreas;
            public List<WorldArea> EndgameAreas
            {
                get
                {
                    if (endgameAreas == null)
                        endgameAreas = EndgameAreasPtrs.Select(x => GameController.Instance.Files.WorldAreas.GetByAddress(x)).ToList();
                    return endgameAreas;
                }
            }
        }


        public class LabyrinthSectionOverrides
        {
            public string Name { get; internal set; }
            public string OverrideName { get; internal set; }

            public override string ToString()
            {
                return OverrideName;
            }
        }
    }

}