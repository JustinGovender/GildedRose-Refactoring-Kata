using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class NormalItem : TypedItem, ITypedItem
    {
        public NormalItem(Item item)
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

