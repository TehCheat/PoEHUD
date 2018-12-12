using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    using RemoteMemoryObjects;

    public class PoeChatElement : Element
    {
        public long TotalMessageCount => ChildCount;
        public string this[int index]
        {
            get
            {
                if (index < TotalMessageCount)
                    return Children[index].AsObject<EntityLabel>().Text;
                return null;
            }
        }
    }
}
