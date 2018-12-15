using PoeHUD.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class StatsDat : FileInMemory
    {
        public enum StatType
        {
            Percents = 1,
            Value2 = 2,
            IntValue = 3,
            Boolean = 4,
            Precents5 = 5
        }

        public Dictionary<string, StatRecord> records =
            new Dictionary<string, StatRecord>(StringComparer.OrdinalIgnoreCase);

        public StatsDat(Memory m, long address) : base(m, address)
        {
            loadItems();
        }

        public StatRecord GetStatByAddress(long address)
        {
            return records.Values.ToList().Find(x => x.Address == address);
        }

        private void loadItems()
        {
			int iCounter = 1;
            foreach (long addr in RecordAddresses())
            {
                var r = new StatRecord(M, addr, iCounter++);
                if (!records.ContainsKey(r.Key))
                    records.Add(r.Key, r);
				iCounter++;
            }
        }

        public class StatRecord
        {
            public readonly string Key;
            public readonly long Address;
            public StatType Type;
            public bool Unknown4;
            public bool Unknown5;
            public bool Unknown6;
            public bool UnknownB;
            public string UserFriendlyName;
			public int ID;
            // more fields can be added (see in visualGGPK)

            public StatRecord(Memory m, long addr, int iCounter)
            {
                Address = addr;
                Key = m.ReadStringU(m.ReadLong(addr + 0), 255);
                Unknown4 = m.ReadByte(addr + 0x8) != 0;
                Unknown5 = m.ReadByte(addr + 0x9) != 0;
                Unknown6 = m.ReadByte(addr + 0xA) != 0;
                Type = Key.Contains("%") ? StatType.Percents : (StatType)m.ReadInt(addr + 0xB);
                UnknownB = m.ReadByte(addr + 0xF) != 0;
                UserFriendlyName = m.ReadStringU(m.ReadLong(addr + 0x10), 255);
				ID = iCounter;
            }

            public override string ToString()
            {
                return String.IsNullOrWhiteSpace(UserFriendlyName) ? Key : UserFriendlyName;
            }

            internal string ValueToString(int val)
            {
                switch (Type)
                {
                    case StatType.Boolean:
                        return val != 0 ? "True" : "False";

                    case StatType.IntValue:
                    case StatType.Value2:
                        return val.ToString("+#;-#");
                    case StatType.Percents:
                    case StatType.Precents5:
                        return val.ToString("+#;-#") + "%";
                }
                return "";
            }
        }
    }
}