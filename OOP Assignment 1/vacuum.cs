using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
   public class Vacuum : Appliance 
    {
        //this will get or set the values of the vaccum by setting the voltage and the grade 
        private string grade;
        private int voltage;

        public string Grade { get => grade; set => grade = value; }
        public int Voltage { get => voltage; set => voltage = value; }

        //this will create a new instance of the vaccum class
        public Vacuum()
        {
            
        }

        //this will create a new instane of the vaccum class with the following parameters such as item number,brand, color and etc.
        public Vacuum(long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, int voltage)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.grade = grade;
            this.voltage = voltage;
        }

        //this method will format the microwave details in order to store them correctly in the file
        public override string formatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{grade};{voltage}";
        }


        //this method will return a string that will repersent the current vaccum and the values listed.
        public override string ToString()
        {
            return base.ToString() + $"Grade : {grade}\nVoltage : {voltage}\n";
        }


    }
}
