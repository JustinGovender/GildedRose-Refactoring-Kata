using System.Collections.Generic;
using System.Linq;
using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems.Factories
{
    public class ItemFactory
    {
        private static readonly IEnumerable<string> ValidMaturingItems = new[] { "Aged Brie" };
        private static readonly IEnumerable<string> ValidLegendaryItems = new[] { "Sulfuras, Hand of Ragnaros" };
        private static readonly IEnumerable<string> ValidEventItems = new[] { "Backstage passes to a TAFKAL80ETC concert" };
        private static readonly string ConjuredItemIdentifier = "Conjured";

        public static IList<ITypedItem> GetTypedItems(IList<Item> items)
        {
            return items.Select(GetTypedItem).ToList();
        }
        
        /// <summary>
        /// Returns the valid typed items from a generic item
        /// </summary>
        /// <returns>typed item</returns>
        private static ITypedItem GetTypedItem(Item item)
        {
            if (ValidMaturingItems.Contains(item.Name))
            {
                return new MaturingItem(item);
            }
            if (ValidLegendaryItems.Contains(item.Name))
            {
                return new LegendaryItem(item);
            }        
            if (ValidEventItems.Contains(item.Name))
            {
                return new EventItem(item);
            }
            if (item.Name.Contains(ConjuredItemIdentifier))
            {
                return new ConjuredItem(item);
            }
            // else default to a normal item
            return new NormalItem(item);
        }
    
    }
}