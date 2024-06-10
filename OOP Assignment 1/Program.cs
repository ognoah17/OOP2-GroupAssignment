using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOP_Assignment_1
{
    class Program
    {
        static List<Appliance> appliances = new List<Appliance>();
        static string filePath = "appliances.txt";

        static void Main(string[] args)
        {
            try
            {
                LoadAppliancesFromFile();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file '{filePath}' was not found. Please ensure it is located in the correct directory.");
                return;
            }

            while (true)
            {
                Console.WriteLine("Welcome to Modern Appliances!");
                Console.WriteLine("How may we assist you?");
                Console.WriteLine("1 – Check out appliance");
                Console.WriteLine("2 – Find appliances by brand");
                Console.WriteLine("3 – Display appliances by type");
                Console.WriteLine("4 – Produce random appliance list");
                Console.WriteLine("5 – Save & exit");
                Console.Write("Enter option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter the item number of an appliance: ");
                        long itemNumber = long.Parse(Console.ReadLine());
                        CheckOutAppliance(itemNumber);
                        break;
                    case "2":
                        Console.Write("Enter brand to search for: ");
                        string brand = Console.ReadLine();
                        FindAppliancesByBrand(brand);
                        break;
                    case "3":
                        Console.WriteLine("Appliance Types");
                        Console.WriteLine("1 – Refrigerators");
                        Console.WriteLine("2 – Vacuums");
                        Console.WriteLine("3 – Microwaves");
                        Console.WriteLine("4 – Dishwashers");
                        Console.Write("Enter type of appliance: ");
                        int type = int.Parse(Console.ReadLine());
                        DisplayAppliancesByType(type);
                        break;
                    case "4":
                        Console.Write("Enter number of appliances: ");
                        int number = int.Parse(Console.ReadLine());
                        ProduceRandomApplianceList(number);
                        break;
                    case "5":
                        SaveAppliancesToFile();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void LoadAppliancesFromFile()
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                long itemNumber = long.Parse(parts[0]);
                string brand = parts[1];
                int quantity = int.Parse(parts[2]);
                double wattage = double.Parse(parts[3]);
                string color = parts[4];
                double price = double.Parse(parts[5]);

                Appliance appliance;
                switch (itemNumber.ToString()[0])
                {
                    case '1':
                        int numDoors = int.Parse(parts[6]);
                        double height = double.Parse(parts[7]);
                        double width = double.Parse(parts[8]);
                        appliance = new Refridgerator(itemNumber, brand, quantity, wattage, color, price, numDoors, height, width);
                        break;
                    case '2':
                        string grade = parts[6];
                        int voltage = int.Parse(parts[7]);
                        appliance = new Vacuum(itemNumber, brand, quantity, wattage, color, price, grade, voltage);
                        break;
                    case '3':
                        double capacity = double.Parse(parts[6]);
                        bool roomType = parts[7].ToLower() == "k";
                        appliance = new Microwave(itemNumber, brand, quantity, wattage, color, price, capacity, roomType);
                        break;
                    case '4':
                    case '5':
                        string feature = parts[6];
                        string soundRating = parts[7];
                        appliance = new Dishwasher(itemNumber, brand, quantity, wattage, color, price, feature, soundRating);

                        Console.WriteLine($"Loaded Dishwasher: Item Number: {itemNumber}, Sound Rating: {soundRating}");
                        break;
                    default:
                        continue;
                }
                appliances.Add(appliance);
            }
        }


        private static void CheckOutAppliance(long itemNumber)
        {
            Appliance appliance = appliances.FirstOrDefault(a => a.ItemNumber == itemNumber);
            if (appliance == null)
            {
                Console.WriteLine($"No appliances found with that item number.");
            }
            else if (!appliance.isAvailable())
            {
                Console.WriteLine($"The appliance is not available to be checked out.");
            }
            else
            {
                appliance.CheckOut();
                Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
            }
        }

        private static void FindAppliancesByBrand(string brand)
        {
            var matchingAppliances = appliances.Where(a => a.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!matchingAppliances.Any())
            {
                Console.WriteLine("No matching appliances found.");
            }
            else
            {
                Console.WriteLine("Matching Appliances:");
                foreach (var appliance in matchingAppliances)
                {
                    Console.WriteLine(appliance.ToString());
                }
            }
        }

        private static void DisplayAppliancesByType(int type)
        {
            List<Appliance> filteredAppliances;
            switch (type)
            {
                case 1:
                    Console.Write("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");
                    int numDoors = int.Parse(Console.ReadLine());
                    filteredAppliances = appliances.OfType<Refridgerator>().Where(r => r.NumDoors == numDoors).Cast<Appliance>().ToList();
                    break;
                case 2:
                    Console.Write("Enter battery voltage value. 18 V (low) or 24 V (high): ");
                    int voltage = int.Parse(Console.ReadLine());
                    filteredAppliances = appliances.OfType<Vacuum>().Where(v => v.Voltage == voltage).Cast<Appliance>().ToList();
                    break;
                case 3:
                    Console.Write("Room where the microwave will be installed: K (kitchen) or W (work site): ");
                    bool roomType = Console.ReadLine().ToLower() == "k";
                    filteredAppliances = appliances.OfType<Microwave>().Where(m => m.RoomType == roomType).Cast<Appliance>().ToList();
                    break;
                case 4:
                    Console.Write("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate): ");
                    string soundRating = Console.ReadLine();
                    filteredAppliances = appliances.OfType<Dishwasher>().Where(d => d.SoundRating.Equals(soundRating, StringComparison.OrdinalIgnoreCase)).Cast<Appliance>().ToList();
                    break;
                default:
                    Console.WriteLine("Invalid appliance type.");
                    return;
            }

                if (!filteredAppliances.Any())
                {
                    Console.WriteLine("No matching appliances found.\n");
                }
                else
                {
                foreach (var appliance in filteredAppliances)
                {
                    Console.WriteLine(appliance.ToString());

                    if (appliance is Dishwasher dishwasher)
                    {
                        Console.WriteLine($"Noise Level: {dishwasher.SoundRating}");
                    }
                }
            }
        }


        private static void ProduceRandomApplianceList(int number)
        {
            var random = new Random();
            var randomAppliances = appliances.OrderBy(a => random.Next()).Take(number).ToList();
            Console.WriteLine("Random appliances:");
            foreach (var appliance in randomAppliances)
            {
                Console.WriteLine(appliance.ToString());
            }
        }

        private static void SaveAppliancesToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var appliance in appliances)
                {
                    writer.WriteLine(appliance.formatForFile());
                }
            }
            Console.WriteLine("Appliances have been saved to file.");
        }
    }
}
