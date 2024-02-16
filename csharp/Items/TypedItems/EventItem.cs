using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class EventItem : Item, ITypedItem
    {
        public EventItem(Item item)
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

