using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
   public class Vacuum : Appliance 
    {
        private string grade;
        private int voltage;

        public string Grade { get => grade; set => grade = value; }
        public int Voltage { get => voltage; set => voltage = value; }

        public Vacuum()
        {
            
        }

        public Vacuum(long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, int voltage)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.grade = grade;
            this.voltage = voltage;
        }

        public override string formatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{grade};{voltage}";
        }

        public override string ToString()
        {
            return base.ToString() + $"Grade : {grade}\nVoltage : {voltage}\n";
        }


    }
}
