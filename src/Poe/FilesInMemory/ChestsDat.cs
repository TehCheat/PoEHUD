using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.FilesInMemory
{
    using Framework;
    using RemoteMemoryObjects;

    public class ChestsDat : UniversalFileWrapper<ChestDat>
	{
	    public ChestsDat(Memory m, long address) : base(m, address) { }
	}
}
