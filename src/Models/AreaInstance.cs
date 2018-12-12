using PoeHUD.Poe.RemoteMemoryObjects;
using System;

namespace PoeHUD.Models
{
    public sealed class AreaInstance
    {
        public int RealLevel { get; }
        public string Name { get; }
        public int Act { get; }
        public bool IsTown { get; }
        public bool IsHideout { get; }
        public bool HasWaypoint { get; }
        public uint Hash { get; }

        public DateTime TimeEntered = DateTime.Now;

		public AreaTemplate Area { get; }

        public AreaInstance(AreaTemplate area, uint hash, int realLevel)
        {
	        Area = area;
            Hash = hash;
            RealLevel = realLevel;
            Name = area.Name;
            Act = area.Act;
            IsTown = area.IsTown;
            HasWaypoint = area.HasWaypoint;
            IsHideout = area.RawName.ToLower().Contains("hideout");
        }

        public override string ToString()
        {
            return $"{Name} ({RealLevel}) #{Hash}";
        }

        public string DisplayName => String.Concat(Name, " (", RealLevel, ")");

        public static string GetTimeString(TimeSpan timeSpent)
        {
            int allsec = (int)timeSpent.TotalSeconds;
            int secs = allsec % 60;
            int mins = allsec / 60;
            int hours = mins / 60;
            mins = mins % 60;
            return String.Format(hours > 0 ? "{0}:{1:00}:{2:00}" : "{1}:{2:00}", hours, mins, secs);
        }
    }
}