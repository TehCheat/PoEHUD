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
    public class UniversalFileWrapper<RecordType> : FileInMemory where RecordType : RemoteMemoryObject, new()
    {
        //We mark this fields as private coz we don't allow to read them directly dut to optimisation. Use EntriesList and methods instead.
        protected Dictionary<long, RecordType> EntriesAddressDictionary { get; set; } = new Dictionary<long, RecordType>();
        protected List<RecordType> CachedEntriesList { get; set; } = new List<RecordType>();
        public List<RecordType> EntriesList
        {
            get
            {
                CheckCache();
                return CachedEntriesList;
            }
        }


        public UniversalFileWrapper(Memory m, long address)
            : base(m, address)
        {
        }

        public RecordType GetByAddress(long address)
        {
            CheckCache();        
            EntriesAddressDictionary.TryGetValue(address, out RecordType result);
            return result;
        }

        public void CheckCache()
        {
            if (EntriesAddressDictionary.Count != 0)
                return;
            
            foreach (long addr in RecordAddresses())
            {
                if (!EntriesAddressDictionary.ContainsKey(addr))
                {
                    var r = GameController.Instance.Game.IngameState.GetObject<RecordType>(addr);
                    EntriesAddressDictionary.Add(addr, r);
                    EntriesList.Add(r);
                    EntryAdded(addr, r);
                }
            }
        }

        protected virtual void EntryAdded(long addr, RecordType entry) { }
    }
}
