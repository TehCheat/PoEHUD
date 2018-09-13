using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Hud.Settings
{
    public class StashTabNode
    {
        public const string EMPTYNAME = "-NoName-";
        public StashTabNode() { }
        public StashTabNode(string name, int visibleIndex)
        {
            Name = name;
            VisibleIndex = visibleIndex;
        }

        public StashTabNode(ServerStashTab serverTab, int id)
        {
            Name = serverTab.Name;
            VisibleIndex = serverTab.VisibleIndex;
            IsRemoveOnly = (serverTab.Flags & ServerStashTab.InventoryTabFlags.RemoveOnly) == ServerStashTab.InventoryTabFlags.RemoveOnly;
            Id = id;
        }

        public string Name { get; set; } = EMPTYNAME;
        public int VisibleIndex { get; set; } = -1;//-1 = Ignore

        [JsonIgnore]
        public bool Exist { get; set; }
        [JsonIgnore]
        internal int Id { get; set; } = -1;
        [JsonIgnore]
        public bool IsRemoveOnly { get; set; }

	    public override string ToString()
	    {
		    return $"Name: {Name}, Id: {Id}, Exist: {Exist}, IsRemoveOnly: {IsRemoveOnly}";
	    }
    }
}
