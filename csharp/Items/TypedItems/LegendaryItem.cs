namespace csharp;

public class LegendaryItem : Item, ITypedItem
{
    public LegendaryItem(Item item)
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

