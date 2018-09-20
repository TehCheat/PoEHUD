using PoeHUD.Framework;
using PoeHUD.Poe.FilesInMemory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Controllers
{
    public class FsController
    {
        public ItemClasses ItemClasses;
        public BaseItemTypes BaseItemTypes;
        public ModsDat Mods;
        public StatsDat Stats;
        public TagsDat Tags;

	    public StatsDat _Stats => Stats;

        //Will be loaded on first access:
        private WorldAreas worldAreas;
        public WorldAreas WorldAreas => worldAreas != null ? worldAreas :
            worldAreas = new WorldAreas(mem, FindFile("Data/WorldAreas.dat"));

        private PassiveSkills passiveSkills;
        public PassiveSkills PassiveSkills => passiveSkills != null ? passiveSkills :
            passiveSkills = new PassiveSkills(mem, FindFile("Data/PassiveSkills.dat"));

        private LabyrinthTrials labyrinthTrials;
        public LabyrinthTrials LabyrinthTrials => labyrinthTrials != null ? labyrinthTrials :
            labyrinthTrials = new LabyrinthTrials(mem, FindFile("Data/LabyrinthTrials.dat"));

        private UniversalFileWrapper<Quest> quests;
        public UniversalFileWrapper<Quest> Quests => quests != null ? quests :
            quests = new UniversalFileWrapper<Quest>(mem, FindFile("Data/Quest.dat"));

        private QuestStates questStates;
        public QuestStates QuestStates => questStates != null ? questStates :
            questStates = new QuestStates(mem, FindFile("Data/QuestStates.dat"));

        private MonsterVarieties monsterVarieties;
        public MonsterVarieties MonsterVarieties => monsterVarieties != null ? monsterVarieties :
            monsterVarieties = new MonsterVarieties(mem, FindFile("Data/MonsterVarieties.dat"));

        private PropheciesDat prophecies;
        public PropheciesDat Prophecies => prophecies != null ? prophecies :
            prophecies = new PropheciesDat(mem, FindFile("Data/Prophecies.dat"));

        private UniversalFileWrapper<AtlasNode> atlasNodes;
        public UniversalFileWrapper<AtlasNode> AtlasNodes => atlasNodes != null ? atlasNodes :
            atlasNodes = new UniversalFileWrapper<AtlasNode>(mem, FindFile("Data/AtlasNode.dat"));


        private readonly Dictionary<string, long> files;
        private readonly Memory mem;

        public FsController(Memory mem)
        {
            this.mem = mem;
            files = GetAllFiles();
            ItemClasses = new ItemClasses();
            BaseItemTypes = new BaseItemTypes(mem, FindFile("Data/BaseItemTypes.dat"));
            Stats = new StatsDat(mem, FindFile("Data/Stats.dat"));
            Tags = new TagsDat(mem, FindFile("Data/Tags.dat"));
            Mods = new ModsDat(mem, FindFile("Data/Mods.dat"), Stats, Tags);
        }

        public Dictionary<string, long> GetAllFiles()
        {
            var fileList = new Dictionary<string, long>();
            long fileRoot = mem.AddressOfProcess + mem.offsets.FileRoot;
            long start = mem.ReadLong(fileRoot + 0x8);

            for (long CurrFile = mem.ReadLong(start); CurrFile != start && CurrFile != 0; CurrFile = mem.ReadLong(CurrFile))
            {
                 var str = mem.ReadStringU(mem.ReadLong(CurrFile + 0x10), 512);

                if (!fileList.ContainsKey(str))
                {
                    fileList.Add(str, mem.ReadLong(CurrFile + 0x18));
                }
            }
            return fileList;
        }

        public long FindFile(string name)
        {
            try
            {
                return files[name];
            }
            catch (KeyNotFoundException)
            {
                const string MESSAGE_FORMAT = "Couldn't find the file in memory: {0}\nTry to restart the game.";
                MessageBox.Show(string.Format(MESSAGE_FORMAT, name), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            return 0;
        }
    }
}