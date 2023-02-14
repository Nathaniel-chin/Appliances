using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Modern Appliances!");
        Console.WriteLine("How may we assist you?");
        Console.WriteLine("1 – Check out appliance");
        Console.WriteLine("2 – Find appliances by brand");
        Console.WriteLine("3 – Display appliances by type");
        Console.WriteLine("4 – Produce random appliance list");
        Console.WriteLine("5 – Save & exit");

        // Prompt the user for an option
        Console.Write("Enter option: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                // Prompt the user for an item number
                Console.Write("Enter item number: ");
                string itemNumber = Console.ReadLine();

                // Search for the corresponding appliance in appliances.txt
                string[] lines = File.ReadAllLines("C:\\Users\\eefif\\Downloads\\Appliance_Assignment\\Appliance Assignment\\Appliance Assignment\\appliances.txt");
                foreach (string line in lines)
                {
                    if (line.StartsWith(itemNumber))
                    {
                        string[] values = line.Split(';');
                        Console.WriteLine("ItemNumber: " + values[0]);
                        Console.WriteLine("Brand: " + values[1]);
                        Console.WriteLine("Quantity: " + values[2]);
                        Console.WriteLine("Wattage: " + values[3]);
                        Console.WriteLine("Color: " + values[4]);
                        Console.WriteLine("Price: " + values[5]);
                        Console.WriteLine("Grade: " + values[6]);
                        Console.WriteLine("BatteryVoltage: " + values[7]);
                        break;
                    }
                }
                break;

            case 2:
                // Prompt user for a brand
                Console.Write("Enter Brand: ");
                string brandName = Console.ReadLine();

                string[] lines2 = File.ReadAllLines("C:\\Users\\eefif\\Downloads\\Appliance_Assignment\\Appliance Assignment\\Appliance Assignment\\appliances.txt");
                foreach (string line in lines2)
                {
                    string[] values = line.Split(';');
                    if (values[1].Equals(brandName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("ItemNumber: " + values[0]);
                        Console.WriteLine("Brand: " + values[1]);
                        Console.WriteLine("Quantity: " + values[2]);
                        Console.WriteLine("Wattage: " + values[3]);
                        Console.WriteLine("Color: " + values[4]);
                        Console.WriteLine("Price: " + values[5]);
                        Console.WriteLine("Grade: " + values[6]);
                        Console.WriteLine("BatteryVoltage: " + values[7]);
                    }
                }
                break;

            case 3:
                // Implement code to display appliances by type
                break;

            case 4:
                // Implement code to produce random appliance list
                break;

            case 5:
                // Implement code to save and exit
                break;

            default:
                Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
                break;
        }

        Console.ReadLine();
    }
}
