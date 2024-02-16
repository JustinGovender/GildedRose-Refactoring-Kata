namespace csharp;

public class EventItem : Item, ITypedItem
{
    public EventItem(Item item)
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

