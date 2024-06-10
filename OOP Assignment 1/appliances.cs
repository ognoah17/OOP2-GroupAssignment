using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    public abstract class Appliance
    {
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Wattage { get => wattage; set => wattage = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }

        public Appliance()
        {

        }

        public Appliance(long itemNumber, string brand, int quantity, double wattage, string color, double price)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
        }

        public bool isAvailable()
        {
            return Quantity > 0;
        }

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
        public abstract string formatForFile();

        public override string ToString()
        {
            return $"Item Number:  {itemNumber} \nBrand: {brand}\nQuantity: {quantity}\nWattage: {wattage}\nColour: {color}\nPrice: {price}\n";
        }
    }
}