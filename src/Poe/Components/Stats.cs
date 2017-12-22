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
        public Dictionary<PlayerStats, int> AllStats => getAllStats();

        private long lastUpdate;
        Dictionary<PlayerStats, int> result  = new Dictionary<PlayerStats,int>();
        private Dictionary<PlayerStats,int> getAllStats()
        {
            if (GameController.Instance.MainTimer.ElapsedMilliseconds > lastUpdate && Game.IngameState.Data.LocalPlayer.IsValid)
            {
                lastUpdate = GameController.Instance.MainTimer.ElapsedMilliseconds + 100;
                result = new Dictionary<PlayerStats, int>();
                var ps = Enum.GetValues(typeof(PlayerStats));
                foreach (PlayerStats s in ps)
                {
                    if (getStat(s, out var r))
                    {
                        result.Add(s, r);
                    }
                }
            }
            return result;
        }

        public bool getStat(PlayerStats key, out int value)
        {
            long ptrStart = M.ReadLong(Address + 0x50);
            long ptrEnd = M.ReadLong(Address + 0x58);
            for (long i = ptrStart; i < ptrEnd; i+=8)
            {
                if (M.ReadInt(i) == (int)key)
                {
                    value = M.ReadInt(i + 0x04);
                    return true;
                }
            }
            value = 0;
            return false;
        }
    }
}