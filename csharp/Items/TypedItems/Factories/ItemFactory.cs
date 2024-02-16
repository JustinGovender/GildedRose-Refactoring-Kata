using System.Collections.Generic;
using System.Linq;

namespace csharp.Items.TypedItems.Factories
{
    public class ItemFactory
    {
        private static readonly IEnumerable<string> ValidMaturingItems = new[] { "Aged Brie" };
        private static readonly IEnumerable<string> ValidLegendaryItems = new[] { "Sulfuras, Hand of Ragnaros" };
        private static readonly IEnumerable<string> ValidEventItems = new[] { "Backstage passes to a TAFKAL80ETC concert" };
    
        /// <summary>
        /// Returns the valid typed items from a generic item
        /// </summary>
        /// <returns>typed item</returns>
        public static Item GetTypedItem(Item item)
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
        
            return new NormalItem(item);
        }
    
    }
}