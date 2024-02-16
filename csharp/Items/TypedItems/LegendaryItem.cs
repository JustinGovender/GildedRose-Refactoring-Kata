using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class LegendaryItem : TypedItem, ITypedItem
    {
        public LegendaryItem(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }
    
        public void makeOneDayOlder()
        {
            throw new System.NotImplementedException();
        }
    }
}

