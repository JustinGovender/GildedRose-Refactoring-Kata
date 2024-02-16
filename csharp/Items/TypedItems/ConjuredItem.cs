using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class ConjuredItem : TypedItem, ITypedItem
    {
        public ConjuredItem(Item item) : base(item) { }
    
        public void makeOneDayOlder()
        {
            DecreaseQuality(IsExpired ? 4 : 2);
            AgeOneDay();
        }
    }
}

