using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
    public class LabyrinthTrials : UniversalFileWrapper<LabyrinthTrial>
    {
        public LabyrinthTrials(Memory m, long address)
            : base(m, address)
        {
        }

        public LabyrinthTrial GetLabyrinthTrialByAreaId(string id)
        {
            return EntriesList.FirstOrDefault(x => x.Area.Id == id);
        }

        public LabyrinthTrial GetLabyrinthTrialById(int index)
        {
            return EntriesList.FirstOrDefault(x => x.Id == index);
        }

        public LabyrinthTrial GetLabyrinthTrialByArea(WorldArea area)
        {
            return EntriesList.FirstOrDefault(x => x.Area == area);
        }

        public static string[] LabyrinthTrialAreaIds = new string[18]
        {
            "1_1_7_1",
            "1_2_5_1",
            "1_2_6_2",
            "1_3_3_1",
            "1_3_6",
            "1_3_15",
            "2_6_7_1",
            "2_7_4",
            "2_7_5_2",
            "2_8_5",
            "2_9_7",
            "2_10_9",
            "EndGame_Labyrinth_trials_spikes",
            "EndGame_Labyrinth_trials_spinners",
            "EndGame_Labyrinth_trials_sawblades_#",
            "EndGame_Labyrinth_trials_lava_#",
            "EndGame_Labyrinth_trials_roombas",
            "EndGame_Labyrinth_trials_arrows"
        };
    }

    public class LabyrinthTrial : RemoteMemoryObject
    {
        private int id = -1;
        public int Id => id != -1 ? id : id = M.ReadInt(Address + 0x10);

        private WorldArea area;
        public WorldArea Area
        {
            get
            {
                if (area == null)
                {
                    var areaPtr = GameController.Instance.Memory.ReadLong(Address + 0x8);
                    area = GameController.Instance.Files.WorldAreas.GetByAddress(areaPtr);
                }
                return area;
            }
        }

	    public override string ToString()
	    {
		    return $"{Area.Name} ({Area.AreaLevel}lvl). Id: {Id}";
	    }
    }
}