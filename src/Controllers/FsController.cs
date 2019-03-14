using PoeHUD.Framework;
using PoeHUD.Poe.FilesInMemory;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private WorldAreas _worldAreas;
        public WorldAreas WorldAreas => _worldAreas ?? (_worldAreas = new WorldAreas(_mem, FindFile("Data/WorldAreas.dat")));

        private PassiveSkills _passiveSkills;
        public PassiveSkills PassiveSkills => _passiveSkills ?? (_passiveSkills = new PassiveSkills(_mem, FindFile("Data/PassiveSkills.dat")));

        private LabyrinthTrials _labyrinthTrials;
        public LabyrinthTrials LabyrinthTrials => _labyrinthTrials ?? (_labyrinthTrials = new LabyrinthTrials(_mem, FindFile("Data/LabyrinthTrials.dat")));

        private UniversalFileWrapper<Quest> _quests;
        public UniversalFileWrapper<Quest> Quests => _quests ?? (_quests = new UniversalFileWrapper<Quest>(_mem, FindFile("Data/Quest.dat")));

        private QuestStates _questStates;
        public QuestStates QuestStates => _questStates ?? (_questStates = new QuestStates(_mem, FindFile("Data/QuestStates.dat")));

        private MonsterVarieties _monsterVarieties;
        public MonsterVarieties MonsterVarieties => _monsterVarieties ?? (_monsterVarieties = new MonsterVarieties(_mem, FindFile("Data/MonsterVarieties.dat")));

        private PropheciesDat _prophecies;
        public PropheciesDat Prophecies => _prophecies ?? (_prophecies = new PropheciesDat(_mem, FindFile("Data/Prophecies.dat")));

        private UniversalFileWrapper<AtlasNode> atlasNodes;
        public UniversalFileWrapper<AtlasNode> AtlasNodes => atlasNodes ?? (atlasNodes = new UniversalFileWrapper<AtlasNode>(_mem, FindFile("Data/AtlasNode.dat")));

        private ChestsDat _chests;
        public ChestsDat Chests => _chests ?? (_chests = new ChestsDat(_mem, FindFile("Data/Chests.dat")));

        private readonly Dictionary<string, long> _files;
        private readonly Memory _mem;

	    private List<GenericFilesInMemory> _debugDatFiles;
	    public List<GenericFilesInMemory> DebugDatFiles => _debugDatFiles ?? (_debugDatFiles = GetFilesForDebug());

	    private List<GenericFilesInMemory> _debugAllFiles;
	    public List<GenericFilesInMemory> DebugAllFiles => _debugAllFiles ?? (_debugAllFiles = GetFilesForDebug(false));

	    private UniversalFileWrapper<BetrayalTarget> _betrayalTargets;
	    public UniversalFileWrapper<BetrayalTarget> BetrayalTargets => _betrayalTargets ?? (_betrayalTargets = new UniversalFileWrapper<BetrayalTarget>(_mem, FindFile("Data/BetrayalTargets.dat")));

	    private UniversalFileWrapper<BetrayalJob> _betrayalJobs;
	    public UniversalFileWrapper<BetrayalJob> BetrayalJobs => _betrayalJobs ?? (_betrayalJobs = new UniversalFileWrapper<BetrayalJob>(_mem, FindFile("Data/BetrayalJobs.dat")));

	    private UniversalFileWrapper<BetrayalRank> _betrayalRanks;
	    public UniversalFileWrapper<BetrayalRank> BetrayalRanks => _betrayalRanks ?? (_betrayalRanks = new UniversalFileWrapper<BetrayalRank>(_mem, FindFile("Data/BetrayalRanks.dat")));

	    private UniversalFileWrapper<BetrayalReward> _betrayalRewards;
	    public UniversalFileWrapper<BetrayalReward> BetrayalRewards => _betrayalRewards ?? (_betrayalRewards = new UniversalFileWrapper<BetrayalReward>(_mem, FindFile("Data/BetrayalTraitorRewards.dat")));

	    private UniversalFileWrapper<BetrayalChoice> _betrayalChoises;
	    public UniversalFileWrapper<BetrayalChoice> BetrayalChoises => _betrayalChoises ?? (_betrayalChoises = new UniversalFileWrapper<BetrayalChoice>(_mem, FindFile("Data/BetrayalChoices.dat")));

	    private UniversalFileWrapper<BetrayalChoiceAction> _betrayalChoiseActions;
	    public UniversalFileWrapper<BetrayalChoiceAction> BetrayalChoiseActions => _betrayalChoiseActions ?? (_betrayalChoiseActions = new UniversalFileWrapper<BetrayalChoiceAction>(_mem, FindFile("Data/BetrayalChoiceActions.dat")));

	    private UniversalFileWrapper<BetrayalDialogue> _betrayalDialogue;
	    public UniversalFileWrapper<BetrayalDialogue> BetrayalDialogue => _betrayalDialogue ?? (_betrayalDialogue = new UniversalFileWrapper<BetrayalDialogue>(_mem, FindFile("Data/BetrayalDialogue.dat")));

        public FsController(Memory mem)
        {
            _mem = mem;
            _files = GetAllFiles();
            ItemClasses = new ItemClasses();
            BaseItemTypes = new BaseItemTypes(mem, FindFile("Data/BaseItemTypes.dat"));
            Stats = new StatsDat(mem, FindFile("Data/Stats.dat"));
            Tags = new TagsDat(mem, FindFile("Data/Tags.dat"));
            Mods = new ModsDat(mem, FindFile("Data/Mods.dat"), Stats, Tags);
        }

        public Dictionary<string, long> GetAllFiles()
        {
            var fileList = new Dictionary<string, long>();
            long fileRoot = _mem.AddressOfProcess + _mem.offsets.FileRoot;
            long start = _mem.ReadLong(fileRoot + 0x8);

            for (var currFile = _mem.ReadLong(start); currFile != start && currFile != 0; currFile = _mem.ReadLong(currFile))
            {
                 var str = _mem.ReadStringU(_mem.ReadLong(currFile + 0x10), 512);

                if (!fileList.ContainsKey(str))
                {
                    fileList.Add(str, _mem.ReadLong(currFile + 0x18));
                }
            }
            return fileList;
        }

        public long FindFile(string name)
        {
            try
            {
                return _files[name];
            }
            catch (KeyNotFoundException)
            {
                const string MESSAGE_FORMAT = "Couldn't find the file in memory: {0}\nTry to restart the game.";
                MessageBox.Show(string.Format(MESSAGE_FORMAT, name), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            return 0;
        }

	    private List<GenericFilesInMemory> GetFilesForDebug(bool datOnly = true)
	    {
		    var result = new List<GenericFilesInMemory>();

		    foreach (var file in _files)
		    {
			    if (datOnly && !file.Key.EndsWith(".dat"))
				    continue;
			    result.Add(new GenericFilesInMemory(_mem, file.Key, file.Value));
		    }

		    result = result.OrderBy(x => x.ToString()).ToList();

		    return result;
	    }

    }
}