using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class EventItem : TypedItem, ITypedItem
    {
        public EventItem(Item item) : base(item) { }
        public void makeOneDayOlder()
        {
            IncreaseQuality(SellIn < 11 ? 2 : 1);
            Quality = IsExpired ? 0 : Quality; //Worth 0 if expired
            AgeOneDay();
        }
    }
}

