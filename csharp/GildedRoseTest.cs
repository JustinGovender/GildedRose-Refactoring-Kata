using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Theory]
        [TestCase(5, 20, 19)] // normal
        [TestCase(0, 20, 18)] // double reduction after expiry
        [TestCase(5, 0, 0)] // quality bottoms out at 0
        [TestCase(0, 1, 0)] // quality bottoms out at 0 even when expired
        public void NormalItemQualityDecreasesCorrectlyPerUpdate(int sellIn, int quality, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "normalItem", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, Items[0].Quality);
        }
        
        [Theory]
        [TestCase(4, 3)]
        [TestCase(0, -1)]
        [TestCase(-1, -2)]
        public void NormalItemSellInDecreasesCorrectlyPerUpdate(int sellIn, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "normalItem", SellIn = sellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, Items[0].SellIn);
        }
    }
}
