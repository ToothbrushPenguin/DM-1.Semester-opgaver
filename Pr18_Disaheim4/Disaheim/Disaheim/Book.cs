namespace Disaheim;

public class Book : Merchandise
{
    public string Title;
    public double Price;

    public Book(string itemId) : this(itemId, "", 0)
    {
        ItemId = itemId;
    }
    public Book(string itemId, string title) : this(itemId, title, 0)
    {
        ItemId = itemId;
        Title = title;
    }

    public Book(string itemId, string title, double price)
    {
        ItemId = itemId;
        Title = title;
        Price = price;
    }

    public override string ToString()
    {
        return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
    }

    public override double GetValue()
    {
        return Price;
    }
}