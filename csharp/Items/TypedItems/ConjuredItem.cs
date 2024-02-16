using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class ConjuredItem : TypedItem, ITypedItem
    {
        public ConjuredItem(Item item)
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

