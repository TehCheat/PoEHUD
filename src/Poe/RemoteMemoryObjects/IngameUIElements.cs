using PoeHUD.Poe.Elements;
using System.Collections.Generic;
using PoeHUD.Controllers;
using System;
using System.Linq;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class IngameUIElements : RemoteMemoryObject
	{
        public Element FlaskBar => GetObject<Element>(M.ReadLong(Address + 0x260, 0x1B0));
		public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0x388);
		public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0x390);
		public PoeChatElement ChatBox => GetObject<PoeChatElement>(M.ReadLong(Address + 0x3F8, 0x2D0, 0xF80));
		public Element QuestTracker => ReadObjectAt<Element>(0x490);
		public Element OpenLeftPanel => ReadObjectAt<Element>(0x4E0);
		public Element OpenRightPanel => ReadObjectAt<Element>(0x4E8);
		public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0x518);
		public StashElement StashElement => ReadObjectAt<StashElement>(0x520); //This element was in serverdata
		public Element TreePanel => ReadObjectAt<Element>(0x548);
		public Element AtlasPanel => ReadObjectAt<Element>(0x550);
		public Map Map => ReadObjectAt<Map>(0x5A0);
        public SyndicatePanel SyndicatePanel => GameController.Instance.Game.IngameState.UIRoot.GetChildFromIndices(1, 64).AsObject<SyndicatePanel>();
        public SubterraneanChart MineMap => ReadObjectAt<SubterraneanChart>(0x6F8);
		public WorldMapElement WorldMap => ReadObjectAt<WorldMapElement>(0xCC0);
		public WorldMapElement AreaInstanceUi => ReadObjectAt<WorldMapElement>(0x7A8);
	    public IncursionWindow IncursionWindow => ReadObjectAt<IncursionWindow>(0x6D8);

		public ItemsOnGroundLabelElement itemOnGroundLabelElement => ReadObjectAt<ItemsOnGroundLabelElement>(0x5A8);
		public IEnumerable<LabelOnGround> ItemsOnGroundLabels => itemOnGroundLabelElement.LabelsOnGround;

		public Element GemLvlUpPanel => ReadObjectAt<Element>(0x8C0);
		public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0x940);//or 0x250

		//public bool IsDndEnabled => M.ReadByte(Address + 0xf92) == 1;
		//public string DndMessage => M.ReadStringU(M.ReadLong(Address + 0xf98));



        private const int QUESTS_OFFSET = 0x218;
		public List<Tuple<Quest, int>> GetUncompletedQuests
		{
			get
			{
				var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + QUESTS_OFFSET));
				return stateListPres.Where(x => x.Item2 > 0).Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
			}
		}

		public List<Tuple<Quest, int>> GetCompletedQuests
		{
			get
			{
				var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + QUESTS_OFFSET));
				return stateListPres.Where(x => x.Item2 == 0).Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
			}
		}

		public Dictionary<string, KeyValuePair<Quest, QuestState>> GetQuestStates
		{
			get
			{
				Dictionary<string, KeyValuePair<Quest, QuestState>> dictionary = new Dictionary<string, KeyValuePair<Quest, QuestState>>();
				foreach (var quest in GetQuests)
				{
					if (quest == null) continue;
					if (quest.Item1 == null) continue;

					QuestState value = GameController.Instance.Files.QuestStates.GetQuestState(quest.Item1.Id, quest.Item2);

					if (value == null) continue;

					if (!dictionary.ContainsKey(quest.Item1.Id))
						dictionary.Add(quest.Item1.Id, new KeyValuePair<Quest, QuestState>(quest.Item1, value));
				}
				return dictionary.OrderBy(x => x.Key).ToDictionary(Key => Key.Key, Value => Value.Value);
			}
		}


		private List<Tuple<Quest, int>> GetQuests
		{
			get
			{
				var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + QUESTS_OFFSET));
				return stateListPres.Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
			}
		}
	}
}

