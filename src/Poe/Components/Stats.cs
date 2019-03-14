using System;
using System.Collections.Generic;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        //Stats goes as sequence of 2 values, 4 byte each. First goes stat ID then goes stat value
        public Dictionary<int, int> StatDictionary
        {
            get
            {
                var statPtrStart = M.ReadLong(Address + 0x50);
                var statPtrEnd = M.ReadLong(Address + 0x58);

	            if (Math.Abs(statPtrEnd - statPtrStart) / 8 > 3000)
	            {
		            return new Dictionary<int, int>();
	            }

                int key = 0;
                int value = 0;
                int total_stats = (int)(statPtrEnd - statPtrStart);
                var bytes = M.ReadBytes(statPtrStart, total_stats);
                var result = new Dictionary<int, int>(total_stats / 8);
                for (int i = 0; i < bytes.Length; i += 8)
                {
                    key = BitConverter.ToInt32(bytes, i);
                    value = BitConverter.ToInt32(bytes, i + 0x04);
                    result[key] = value;
                }
                return result;
            }
        }

        public Dictionary<GameStat, int> GameStatDictionary
        {
            get
            {
                var statPtrStart = M.ReadLong(Address + 0x50);
                var statPtrEnd = M.ReadLong(Address + 0x58);

	            if (Math.Abs(statPtrEnd - statPtrStart) / 8 > 3000)
	            {
		            return new Dictionary<GameStat, int>();
	            }

                var total_stats = (int)(statPtrEnd - statPtrStart);
                var bytes = M.ReadBytes(statPtrStart, total_stats);
                var result = new Dictionary<GameStat, int>(total_stats / 8);
                for (var i = 0; i < bytes.Length; i += 8)
                {
                    var key = BitConverter.ToInt32(bytes, i);
                    var value = BitConverter.ToInt32(bytes, i + 0x04);
                    result.Add((GameStat)key, value);
                }
                return result;
            }
        }
    }
}
