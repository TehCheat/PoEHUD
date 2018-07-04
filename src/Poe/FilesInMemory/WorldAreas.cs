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
    public partial class WorldAreas : UniversalFileWrapper<WorldArea>
    {
        private Dictionary<int, WorldArea> AreasIndexDictionary = new Dictionary<int, WorldArea>();

        public WorldAreas(Memory m, long address)
            : base(m, address)
        {
        }

        public WorldArea GetAreaByAreaId(int index)
        {
            CheckCache();

            WorldArea area;
            AreasIndexDictionary.TryGetValue(index, out area);
            return area;
        }

        public WorldArea GetAreaByAreaId(string id)
        {
            CheckCache();
            return AreasIndexDictionary.Where(area => area.Value.Id == id).First().Value;
        }
        private int IndexCounter;
        protected override void EntryAdded(long addr, WorldArea entry)
        {
            entry.Index = IndexCounter++;
            AreasIndexDictionary.Add(entry.Index, entry);
        }
    }
}