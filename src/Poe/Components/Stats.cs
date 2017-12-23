using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.DebugPlug;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        
            public long statPtrStart => M.ReadLong(Address + 0x50);
            public long statPtrEnd => M.ReadLong(Address + 0x58);
        public Dictionary<PlayerStats, int> AllStats
        {
            get
            {
                UpdateAllDates();
                return result;
            }
        }
        private long nextUpdate;
        Dictionary<PlayerStats, int> result = new Dictionary<PlayerStats, int>();


   /*     public bool getStat(PlayerStats key, out int value)
        {
            long ptrStart = M.ReadLong(Address + 0x50);
            long ptrEnd = M.ReadLong(Address + 0x58);

            for (long i = ptrStart; i < ptrEnd; i += 8)
            {
                if (M.ReadInt(i) == (int) key)
                {
                    value = M.ReadInt(i + 0x04);
                    return true;
                }
            }
            value = 0;
            return false;
        }*/

        void UpdateAllDates()
        {
            if (GameController.Instance.MainTimer.ElapsedMilliseconds > nextUpdate)
            {
                nextUpdate = GameController.Instance.MainTimer.ElapsedMilliseconds + GameController.Instance.Performance.meanDeltax5;
                long ptrStart = M.ReadLong(Address + 0x50);
                long ptrEnd = M.ReadLong(Address + 0x58);
                var bytes = M.ReadBytes(ptrStart, (int) (ptrEnd - ptrStart));
                var dict = new Dictionary<PlayerStats, int>();
                for (int i = 0; i < bytes.Length; i += 8)
                    dict[(PlayerStats) BitConverter.ToInt32(bytes, i)] = BitConverter.ToInt32(bytes, i + 0x04);
                result = dict;
            }
        }


        public bool getStat(PlayerStats key, out int value)
        {
            UpdateAllDates();
            if (result.TryGetValue(key, out var res))
            {
                value = res;
                return true;
            }
            value = 0;
            return false;
        }
    }
}