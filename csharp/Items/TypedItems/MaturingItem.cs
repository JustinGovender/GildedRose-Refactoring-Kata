using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class MaturingItem : TypedItem, ITypedItem
    {
        public MaturingItem(Item item) : base(item) { }
    
        public void makeOneDayOlder()
        {
            throw new System.NotImplementedException();
        }
    }
}

