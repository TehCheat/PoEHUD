using System;
using System.Collections.Generic;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        //Stats goes as sequence of 2 values, 4 byte each. First goes stat ID then goes stat value
        public Dictionary<GameStat, int> StatDictionary
        {
            get
            {
                var statPtrStart = M.ReadLong(Address + 0x50);
                var statPtrEnd = M.ReadLong(Address + 0x58);

                int key = 0;
                int value = 0;
                int total_stats = (int)(statPtrEnd - statPtrStart);
                var bytes = M.ReadBytes(statPtrStart, total_stats);
                var result = new Dictionary<GameStat, int>(total_stats / 8);
                for (int i = 0; i < bytes.Length; i += 8)
                {
                    key = BitConverter.ToInt32(bytes, i);
                    value = BitConverter.ToInt32(bytes, i + 0x04);
                    result[(GameStat)key] = value;
                }
                return result;
            }
        }
    }
}
