using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    public class Refridgerator : Appliance
    {
        private int numDoors;
        private double height;
        private double width;

        public int NumDoors { get => numDoors; set => numDoors = value; }
        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public Refridgerator()
        {
            
        }

        public Refridgerator(long itemNumber, string brand, int quantity, double wattage, string color, double price, int numDoors, double height, double width)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.numDoors = numDoors;
            this.height = height;
            this.width = width;
        }

        public override string formatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{NumDoors};{Height};{Width}";
        }

        public override string ToString()
        {
            return base.ToString() + $"Number of doors: {NumDoors}\nHeight: {Height}\nWidth: {Width}\n";
        }


    }
}
