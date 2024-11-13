using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace Disaheim;

public class Amulet : Merchandise
{
    public double LowQualityValue { get; set; } = 12.5;
    public double MediumQualityValue { get; set; } = 20;
    public double HighQualityValue { get; set; } = 27.5;


    public Level Quality;
    public string Design;
    
    public Amulet(string itemId) : this("",Level.medium, "")
    {
        ItemId = itemId;
    }
    public Amulet(string itemId, Level quality) : this("", quality, "")
    {
        ItemId = itemId;
        Quality = quality;
    }

    public Amulet(string itemId, Level quality, string design)
    {
        ItemId = itemId;
        Quality = quality;
        Design = design;
    }

    public override string ToString()
    {
        return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
    }

    public override double GetValue()
    {
        double Price = 0;
        switch (Quality)
        {
            case Level.low:
                Price = LowQualityValue;
                break;
            case Level.medium:
                Price = MediumQualityValue;
                break;
            case Level.high:
                Price = HighQualityValue;
                break;
        }
        return Price;
    }
}