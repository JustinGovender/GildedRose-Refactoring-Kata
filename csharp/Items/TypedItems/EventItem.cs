using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class EventItem : TypedItem, ITypedItem
    {
        public EventItem(Item item) : base(item) { }
        public void makeOneDayOlder()
        {
            throw new System.NotImplementedException();
        }
    }
}

