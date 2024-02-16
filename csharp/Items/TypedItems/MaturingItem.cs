namespace csharp;

public class MaturingItem : Item, ITypedItem
{
    public MaturingItem(Item item)
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

