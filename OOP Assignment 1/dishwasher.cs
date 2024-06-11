using OOP_Assignment_1;
using System.Diagnostics;

public class Dishwasher : Appliance
{
    private string feature;
    private string soundRating;
    private string soundRatingFriendly;

    //this method will get or set the features of the dishwasher
    public string Feature { get => feature; set => feature = value; }

    // this method will get or set the sound rating of the dishwasher 
    public string SoundRating
    {
        get => soundRating;
        set
        {
            soundRating = value;
            SetSoundRatingFriendly(value);
        }
    }

    //this will get the friendly sound rating 
    public string SoundRatingFriendly { get => soundRatingFriendly; }

    //this will create a new instance of the dishwasher class
    public Dishwasher()
    {
    }

    // this will create a new instance of the dishwaasher class with the specified parameters such as item number, brand, quantity , wattage, color and etc.
    public Dishwasher(long itemNumber, string brand, int quantity, double wattage, string color, double price, string feature, string soundRating)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        this.feature = feature;
        this.SoundRating = soundRating; // Use the property to set the correct value
    }

    //this method will set the friendly repersentation of the sound rating by making them easy to read for people who aren't knowledgeble in appliances
    private void SetSoundRatingFriendly(string rating)
    {
        soundRatingFriendly = rating.Replace("Qu", "Quiet")
                                    .Replace("Qt", "Quietest")
                                    .Replace("Qr", "Quieter")
                                    .Replace("M", "Moderate");
    }

    //this method will format the dishwasher details in order to store them in the file correctly 
    public override string formatForFile()
    {
        return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{feature};{soundRating}";
    }


    //this method will return a string repersenting the current dishwasher 
    public override string ToString()
    {
        return base.ToString() + $"Feature: {feature}\nSound Rating: {soundRatingFriendly}\n";
    }
}
