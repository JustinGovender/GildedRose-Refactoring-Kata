namespace csharp;

public class ConjuredItem : Item, ITypedItem
{
    public ConjuredItem(Item item)
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

