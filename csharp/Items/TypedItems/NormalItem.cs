using csharp.Items.TypedItems.Interfaces;

namespace csharp.Items.TypedItems
{
    public class NormalItem : TypedItem, ITypedItem
    {
        public NormalItem(Item item) : base(item) { }

        public void makeOneDayOlder()
        {
            throw new System.NotImplementedException();
        }
    }
}

