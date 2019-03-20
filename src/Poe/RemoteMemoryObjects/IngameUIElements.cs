using PoeHUD.Controllers;
using PoeHUD.Poe.Elements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0x370);
        public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0x378);
        public PoeChatElement ChatBox => GetObject<PoeChatElement>(M.ReadLong(Address + 0x3F8, 0x2D0, 0xF80));
        public Element QuestTracker => ReadObjectAt<Element>(0x478);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0x4E0 + 0x8/*4F0*/);
        public Element OpenRightPanel => ReadObjectAt<Element>(0x4E8 + 0x8/*4F8 */);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0x518 + 0x8);
        public StashElement StashElement => ReadObjectAt<StashElement>(0x520 + 0x8); //This element was in serverdata
        public Element TreePanel => ReadObjectAt<Element>(0x548 + 0x8);
        public Element AtlasPanel => ReadObjectAt<Element>(0x550 + 0x8);
        public Map Map => ReadObjectAt<Map>(0x5A0 + 0x8);
        public SyndicatePanel SyndicatePanel => GetObject<SyndicatePanel>(M.ReadLong(Address + 0xEF8, 0xA50 + 0x8));
        public SubterraneanChart MineMap => ReadObjectAt<SubterraneanChart>(0x6F8 + 0x8/*0xED8*/);
        public WorldMapElement WorldMap => ReadObjectAt<WorldMapElement>(0xCC0 + 0x8);
        public WorldMapElement AreaInstanceUi => ReadObjectAt<WorldMapElement>(0x7A8 + 0x8);

        public IEnumerable<LabelOnGround> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = GetObject<ItemsOnGroundLabelElement>(M.ReadLong(Address + 0x5A8 + 0x8));
                return itemsOnGroundLabelRoot.LabelsOnGround;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xBA0 + 0x8);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0x928 + 0x8);//or 0x250

        //public bool IsDndEnabled => M.ReadByte(Address + 0xf92) == 1;
        //public string DndMessage => M.ReadStringU(M.ReadLong(Address + 0xf98));




        public List<Tuple<Quest, int>> GetUncompletedQuests
        {
            get
            {
                var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + 0x9F0 + 0x8));
                return stateListPres.Where(x => x.Item2 > 0).Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
            }
        }

        public List<Tuple<Quest, int>> GetCompletedQuests
        {
            get
            {
                var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + 0x9F0 + 0x8));
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
                var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + 0x9F0 + 0x8));
                return stateListPres.Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
            }
        }
    }
}
