using PoeHUD.Poe.Elements;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Controllers;
using System;
using System.Linq;
using PoeHUD.Framework;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0xB58);
        public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0xB60);
        public PoeChatElement ChatBox => GetObject<PoeChatElement>(M.ReadLong(Address + 0xBD8, 0xAB8, 0xC30));
        public Element QuestTracker => ReadObjectAt<Element>(0xC50);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xC90);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xC98);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xCC8);
        public Element TreePanel => ReadObjectAt<Element>(0xCF8);
        public Element AtlasPanel => ReadObjectAt<Element>(0xD00);
        public Map Map => ReadObjectAt<Map>(0xD50);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xD58);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xF70);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xFE8);

        public bool IsDndEnabled => M.ReadByte(Address + 0xf92) == 1;
        public string DndMessage => M.ReadStringU(M.ReadLong(Address + 0xf98));




        public List<Tuple<Quest, int>> GetUncompletedQuests
        {
            get
            {
                var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + 0x9e0));
                return stateListPres.Where(x => x.Item2 > 0).Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
            }
        }

        public List<Tuple<Quest, int>> GetCompletedQuests
        {
            get
            {
                var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + 0x9e0));
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

                    if(!dictionary.ContainsKey(quest.Item1.Id))
                    dictionary.Add(quest.Item1.Id, new KeyValuePair<Quest, QuestState>(quest.Item1, value));
                }
                return dictionary.OrderBy(x => x.Key).ToDictionary(Key => Key.Key, Value => Value.Value);
            }
        }


        private List<Tuple<Quest, int>> GetQuests
        {
            get
            {
                var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + 0x9e0));
                return stateListPres.Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
            }
        }
    }
}

