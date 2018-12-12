using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class WorldArea : RemoteMemoryObject
    {
        private string id;
        public string Id => id != null ? id :
            id = M.ReadStringU(M.ReadLong(Address));

        public int Index { get; internal set; }

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 8), 255);


        public int Act => M.ReadInt(Address + 0x10);
        public bool IsTown => M.ReadByte(Address + 0x14) == 1;
        public bool HasWaypoint => M.ReadByte(Address + 0x15) == 1;
        public int AreaLevel => M.ReadInt(Address + 0x26);
        public int WorldAreaId => M.ReadInt(Address + 0x2a);

        public bool IsAtlasMap => Id.StartsWith("MapAtlas");
        public bool IsMapWorlds => Id.StartsWith("MapWorlds");
        public bool IsCorruptedArea => Id.Contains("SideArea") || Id.Contains("Sidearea");
        public bool IsMissionArea => Id.Contains("Mission");
        public bool IsDailyArea => Id.Contains("Daily");
        public bool IsMapTrialArea => Id.StartsWith("EndGame_Labyrinth_trials");
        public bool IsLabyrinthArea => !IsMapTrialArea && Id.Contains("Labyrinth");
        public bool IsAbyssArea => Id.Equals("AbyssLeague") ||
                            Id.Equals("AbyssLeague2") ||
                            Id.Equals("AbyssLeagueBoss") ||
                            Id.Equals("AbyssLeagueBoss2") ||
                            Id.Equals("AbyssLeagueBoss3");

        private List<WorldArea> connections;
        public List<WorldArea> Connections
        {
            get
            {
                if (connections == null)
                {
                    connections = new List<WorldArea>();
                    var m = GameController.Instance.Memory;

                    var connectionsCount = M.ReadInt(Address + 0x16);
                    if (connectionsCount > 10)
                    {
                        DebugPlug.DebugPlugin.LogMsg("Error reading WorldArea.Connections. Exceeded limit (5): " + connectionsCount, 1);
                        return connections;
                    }

                    var connectionsPtr = M.ReadLong(Address + 0x1e);            
                    for (int i = 0; i < connectionsCount; i++)
                    {
                        var newArea = GameController.Instance.Files.WorldAreas.GetByAddress(m.ReadLong(connectionsPtr));
                        connections.Add(newArea);
                        connectionsPtr += 8;
                    }
                }
                return connections;
            }
        }

        private List<WorldArea> corruptedAreas;
        public List<WorldArea> CorruptedAreas
        {
            get
            {
                if (corruptedAreas == null)
                {
                    corruptedAreas = new List<WorldArea>();
                    var m = GameController.Instance.Memory;

                    var corruptedAreasCount = M.ReadInt(Address + 0xfb);
                    if (corruptedAreasCount > 10)
                    {
                        DebugPlug.DebugPlugin.LogMsg("Error reading WorldArea.CorruptedAreas. Exceeded limit (5): " + corruptedAreasCount, 1);
                        return connections;
                    }
                    var corruptedAreasPtr = M.ReadLong(Address + 0x103);
                    for (int i = 0; i < corruptedAreasCount; i++)
                    {
                        var newArea = GameController.Instance.Files.WorldAreas.GetByAddress(m.ReadLong(corruptedAreasPtr));
                        corruptedAreas.Add(newArea);
                        corruptedAreasPtr += 8;
                    }
                }
                return corruptedAreas;
            }
        }

        public override string ToString()
        {
            return $"{Name}";//, Connections: {string.Join(", ", Connections.Select(x => x.Name).ToArray())}
        }
    }
}
