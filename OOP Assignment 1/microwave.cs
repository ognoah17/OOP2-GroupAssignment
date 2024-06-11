using OOP_Assignment_1;
using System.Diagnostics;

public class Microwave : Appliance
{
    private double capacity;
    private string roomType;

    //this will get or set the capacity of the microwave 
    public double Capacity
    {
        get => capacity;
        set => capacity = value;
    }
    // this will get or set the type of room where the microwave should be used
    public string RoomType
    {
        get => roomType;
        set => roomType = value;
    }
    
    //this will create a new instance of the microwave class
    public Microwave()
    {
    }

    //using this we will create a new instance of the microwave class with the pararmeters listed such as item number,brand, wattage and etc..
    public Microwave(long itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomType)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        this.capacity = capacity;
        this.roomType = roomType;
    }

    //using this method we will format the microwave detais in order to store them correctly in the file using a string.
    public override string formatForFile()
    {
        return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{capacity};{roomType}";
    }


    //this method will display a string the repersents the current microwave which has been chosen.
    public override string ToString()
    {
        string displayRoomType;
        if (roomType == "k")
        {
            displayRoomType = "Kitchen";
        }
        else if (roomType == "w")
        {
            displayRoomType = "Work Site";
        }
        else
        {
            displayRoomType = roomType;
        }

        return base.ToString() + $"Capacity: {capacity}\nRoom Type: {displayRoomType}\n";
    }
}
