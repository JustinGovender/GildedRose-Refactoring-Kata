using System.Collections.Generic;
using ApprovalUtilities.Utilities;
using csharp.Items.TypedItems.Factories;
using csharp.Items.TypedItems.Interfaces;

namespace csharp
{
    public class GildedRose
    {
        public readonly IList<ITypedItem> Items;
        public GildedRose(IList<Item> items)
        {
            Items = ItemFactory.GetTypedItems(items);
        }

        public void UpdateQuality()
        {
            Items.ForEach(item => item.makeOneDayOlder());
        }
    }
}
