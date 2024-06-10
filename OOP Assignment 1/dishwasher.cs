using OOP_Assignment_1;
using System.Diagnostics;

public class Dishwasher : Appliance
{
    private string feature;
    private string soundRating;

    public string Feature { get => feature; set => feature = value; }
    public string SoundRating
    {
        get => soundRating;
        set
        {
            soundRating = value;
            switch (value.ToLower())
            {
                case "qt":
                    soundRating = "Quietest";
                    break;
                case "qr":
                    soundRating = "Quieter";
                    break;
                case "qu":
                    soundRating = "Quiet";
                    break;
                case "m":
                    soundRating = "Moderate";
                    break;
                default:
                    soundRating = value;
                    break;
            }
        }
    }

    public Dishwasher()
    {

    }

    public Dishwasher(long itemNumber, string brand, int quantity, double wattage, string color, double price, string feature, string soundRating)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        this.feature = feature;
        this.SoundRating = soundRating; // Use the property to set the correct value
    }

    public override string formatForFile()
    {
        return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{feature};{soundRating}";
    }

    public override string ToString()
    {
        return base.ToString() + $"Feature: {feature}\nSound Rating: {soundRating}\n";
    }
}
