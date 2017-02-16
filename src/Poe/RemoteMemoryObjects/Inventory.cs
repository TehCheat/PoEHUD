using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Inventory : RemoteMemoryObject
    {
        public long ItemCount => M.ReadLong(Address + 0x410, 0x5F0, 0x50);
        public int Width => 0;
        public int Height => 0;

        public List<Entity> Items
        {
            get
            {
                var list = new List<Entity>();
                // Max size of Player Inventory excluding stashes.
                if (ItemCount > 60 || ItemCount <= 0)
                {
                    return list;
                }
                var hashSet = new HashSet<long>();
                long itmIndex = 0;
                long itmAddr = 0;

                long invIndex = 0;
                long invAddr = M.ReadLong(Address + 0x410, 0x5F0, 0x30);
                while (itmIndex < ItemCount)
                {
                    itmAddr = M.ReadLong(invAddr + (invIndex * 8));
                    if (itmAddr != 0 && !hashSet.Contains(itmAddr))
                    {
                        list.Add(ReadObject<Entity>(itmAddr));
                        hashSet.Add(itmAddr);
                        itmIndex++;
                    }
                    invIndex++;
                }
                return list;
            }
        }
        // Return null incase of error or item doesn't exists at that location.
        public Entity this[int X, int Y]
        {
            get
            {
                if (ItemCount > 60 || ItemCount <= 0)
                {
                    return null;
                }
                var hashSet = new HashSet<long>();
                long itmIndex = 0;
                long itmAddr = 0;

                long invIndex = 0;
                long invAddr = M.ReadLong(Address + 0x410, 0x5F0, 0x30);

                int InvertPosX = 0;
                int InvertPosY = 0;

                while (itmIndex < ItemCount)
                {
                    itmAddr = M.ReadLong(invAddr + (invIndex * 8));
                    InvertPosX = M.ReadInt(itmAddr + 0x8);
                    InvertPosY = M.ReadInt(itmAddr + 0xC);
                    if (itmAddr != 0 && !hashSet.Contains(itmAddr))
                    {
                        if (X == InvertPosX && Y == InvertPosY)
                            return ReadObject<Entity>(itmAddr);
                        hashSet.Add(itmAddr);
                        itmIndex++;
                    }
                    invIndex++;
                }
                return null;
            }
        }
    }
}