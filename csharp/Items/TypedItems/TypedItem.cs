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
    public int Quality { get => _item.Quality; set => _item.Quality = value; }
}