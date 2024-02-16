using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class LegendaryItem : TypedItem, ITypedItem
    {
        public LegendaryItem(Item item) : base(item) { }
    
        public void makeOneDayOlder()
        {
            throw new System.NotImplementedException();
        }
    }
}

