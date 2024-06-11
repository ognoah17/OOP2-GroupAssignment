using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    //this class repersents a general appliance.
    public abstract class Appliance
    {
        
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        // this will get or set the item number of the appliance 
        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        // this will get or set the brand name of the appliance 
        public string Brand { get => brand; set => brand = value; }
        // this will get or set the quantity of said appliance in stock
        public int Quantity { get => quantity; set => quantity = value; }
        // this will get or set the wattage of said appliance 
        public double Wattage { get => wattage; set => wattage = value; }
        // this will get or set the color of the appliance 
        public string Color { get => color; set => color = value; }
        //this will get or set the price of the appliance 
        public double Price { get => price; set => price = value; }

        public Appliance()
        {

        }

        //this method initaliazes a new instantce of the appliance class with the item number, brand, quantity, wattage, color and price.
        public Appliance(long itemNumber, string brand, int quantity, double wattage, string color, double price)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
        }

        //this method determines whether or not the chosen appliance is avaliable if the quantity is grater then 0 it will return a true value, otherwise it will be false.
        public bool isAvailable()
        {
            return Quantity > 0;
        }

        //this method will check and see if the appliance is avaliable by caling the previous method and then it wiil decrease the quantity by 1 otherwise it will say the appliance is not avaliable
        public void CheckOut()
        {
            if (isAvailable())
            {
                Quantity--;
            }
            else
            {
                Console.WriteLine("Appliance is not available.");
            }
        }

        //this method is used in order to format the appliane details such as brand, price, wattage and etc in order to store it correctly
        public abstract string formatForFile();

        //this method will return a string that repersents the current appliance which has been chosen or called
        public override string ToString()
        {
            return $"Item Number:  {itemNumber} \nBrand: {brand}\nQuantity: {quantity}\nWattage: {wattage}\nColour: {color}\nPrice: {price}\n";
        }
    }
}