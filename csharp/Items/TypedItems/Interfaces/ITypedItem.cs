namespace csharp.Items.TypedItems.Interfaces
{
    public interface ITypedItem
    {
        public void makeOneDayOlder();

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}