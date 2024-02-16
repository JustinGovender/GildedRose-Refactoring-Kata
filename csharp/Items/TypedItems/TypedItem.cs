namespace csharp.Items.TypedItems;

public class TypedItem
{
    protected readonly Item _item;

    protected TypedItem(Item item)
    {
        _item = item;
    }

    public string Name { get => _item.Name; set => _item.Name = value; }
    public int SellIn { get => _item.SellIn; set => _item.SellIn = value; }

    public int Quality
    {
        get => _item.Quality;
        set => _item.Quality = value > 0 ? value : 0; // Quality can't be less than 0
    }

    public bool IsExpired => _item.SellIn <= 0;

    protected void AgeOneDay()
    {
        SellIn -= 1;
    }

    protected void DecreaseQuality(int amountToDecreaseBy)
    {
        Quality -= amountToDecreaseBy;
    }
    protected void IncreaseQuality(int amountToIncreaseBy)
    {
        Quality += amountToIncreaseBy;
        Quality = Quality > 50 ? 50 : Quality;
    }
    
}