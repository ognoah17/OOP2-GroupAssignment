using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    public class Microwave : Appliance
    {
        private double capacity;
        private bool roomType;

        public double Capacity { get => capacity; set => capacity = value; }
        public bool RoomType { get => roomType; set => roomType = value; }

        public Microwave()
        {
            

        }

        public Microwave(long itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, bool roomType)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.capacity = capacity;
            this.roomType = roomType;
        }

        public override string formatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{capacity};{roomType}";
        }

        public override string ToString()
        {
            return base.ToString() + $"Capacity: {capacity}\nRoomType: {roomType}";
        }
    }
}
