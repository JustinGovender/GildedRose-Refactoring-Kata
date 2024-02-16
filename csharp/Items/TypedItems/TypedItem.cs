namespace csharp.Items.TypedItems;

public abstract class TypedItem: Item
{
    public void DecreaseSellInByOneDay()
    {
        SellIn -= 1;
    }
}