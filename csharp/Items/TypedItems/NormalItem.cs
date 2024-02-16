namespace csharp;

public class NormalItem : Item, ITypedItem
{
    public NormalItem(Item item)
    {
        Name = item.Name;
        SellIn = item.SellIn;
        Quality = item.Quality;
    }
    public void makeOneDayOlder()
    {
        throw new System.NotImplementedException();
    }
}

