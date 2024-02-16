using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
            Assert.AreEqual(expected, app.Items[0].Quality);
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
            Assert.AreEqual(expected, app.Items[0].SellIn);
        }
        
        [Theory]
        [TestCase(5, 20, 21)] // goes up by one as it matures
        [TestCase(0, 20, 22)] // quality goes up double when expired
        [TestCase(5, 50, 50)] // quality maxes out at 50
        [TestCase(0, 50, 50)] // quality maxes out at 50 even when expired
        public void MaturingItemQualityDecreasesCorrectlyPerUpdate(int sellIn, int quality, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].Quality);
        }
        
        [Theory]
        [TestCase(4, 3)]
        [TestCase(0, -1)]
        [TestCase(-1, -2)]
        public void MaturingItemSellInDecreasesCorrectlyPerUpdate(int sellIn, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].SellIn);
        }
        
        [Theory]
        [TestCase(11, 20, 21)] // goes up by one as it matures
        [TestCase(11, 50, 50)] // quality maxes out at 50
        [TestCase(10, 20, 22)] // quality goes up double when 10 or less days till expiry
        [TestCase(5, 50, 50)] // quality maxes out at 50 even when when 10 or less days till expiry
        [TestCase(0, 50, 0)] // quality drops to zero when expired
        public void EventItemQualityDecreasesCorrectlyPerUpdate(int sellIn, int quality, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].Quality);
        }
        
        [Theory]
        [TestCase(4, 3)]
        [TestCase(0, -1)]
        [TestCase(-1, -2)]
        public void EventItemSellInDecreasesCorrectlyPerUpdate(int sellIn, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].SellIn);
        }
        
        [Theory]
        [TestCase(5, 80, 80)] // normal
        [TestCase(0, 80, 80)] // quality doesn't change when expired
        public void LegendaryItemQualityDecreasesCorrectlyPerUpdate(int sellIn, int quality, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].Quality);
        }
        
        [Theory]
        [TestCase(4, 4)] // Legendary items don't change their sell in value
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        public void LegendaryItemSellInDecreasesCorrectlyPerUpdate(int sellIn, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].SellIn);
        }
        
        [Theory]
        [TestCase(5, 20, 18)] // conjured items have double normal reduction
        [TestCase(0, 20, 16)] // quadruple reduction after expiry
        [TestCase(5, 0, 0)] // quality bottoms out at 0
        [TestCase(0, 1, 0)] // quality bottoms out at 0 even when expired
        public void ConjuredItemQualityDecreasesCorrectlyPerUpdate(int sellIn, int quality, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].Quality);
        }
        
        [Theory]
        [TestCase(4, 3)]
        [TestCase(0, -1)]
        [TestCase(-1, -2)]
        public void ConjuredItemSellInDecreasesCorrectlyPerUpdate(int sellIn, int expected)
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = sellIn, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(expected, app.Items[0].SellIn);
        }
    }
}
