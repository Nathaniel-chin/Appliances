using Appliance_Assignment;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;



// OOP2 
//
// 
//
// Main Menu
//
// 1- Search for appliance by item number
// 2- Search for appliance by brand
// 3 - Display appliances by type
// 4 - Produce Random Appliance List
// 5 - Save and exit
// No processing calculations
// Last Modified: 2023-13-02
// Authorsr: Nathaniel Chin, Evan Eng
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
                    string[] lines = File.ReadAllLines("C:\\Users\\nichi\\OneDrive\\Desktop\\OOP2\\Appliance Assignment\\Appliance Assignment\\appliances.txt");
                foreach (string line in lines)
                {
                    if (line.StartsWith(itemNumber))
                    {
                        Console.WriteLine(line);
                        break;
                    }
                }
                break;

                case 2:
                        // Prompt user for a brand
                        Console.Write("Enter Brand: ");
                        string brandName = Console.ReadLine();

                        string[] lines2 = File.ReadAllLines("C:\\Users\\nichi\\OneDrive\\Desktop\\OOP2\\Appliance Assignment\\Appliance Assignment\\appliances.txt");
                        foreach (string line in lines2)
                        {
                            string[] values = line.Split(';');
                            if (values[1].Equals(brandName, StringComparison.OrdinalIgnoreCase))
                            {
                                if (line.StartsWith("1"))
                                {
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Number of Doors: " + values[6]);
                                    Console.WriteLine("Height: " + values[7]);
                                    Console.WriteLine("Width: " + values[8]);
                                }
                                else if (line.StartsWith("2"))
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
                                else if (line.StartsWith("3"))
                                {
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Power: " + values[6]);
                                    Console.WriteLine("Capacity: " + values[7]);
                                }
                                else if (line.StartsWith("4"))
                                {
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Feature: " + values[6]);
                                    Console.WriteLine("SoundRating: " + values[7]);
                                }
                                else if (line.StartsWith("5"))
                                {
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Feature: " + values[6]);
                                    Console.WriteLine("SoundRating: " + values[7]);
                                }
                            }
                        }
                        break;


                    case 3:
                        // Prompt user for an appliance type
                        Console.Write("Enter Appliance Type (Refrigerator, Vacuum, Microwave, Dishwasher): ");
                        string applianceType = Console.ReadLine();
                        string[] lines3 = File.ReadAllLines("C:\\Users\\nichi\\OneDrive\\Desktop\\OOP2\\Appliance Assignment\\Appliance Assignment\\appliances.txt");

                        // Search for appliances by type
                        if (applianceType.Equals("Refrigerator", StringComparison.OrdinalIgnoreCase))
                        {
                            foreach (string line in lines3)
                            {
                                if (line.StartsWith("1"))
                                {
                                    string[] values = line.Split(';');
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Number of Doors: " + values[6]);
                                    Console.WriteLine("Height: " + values[7]);
                                    Console.WriteLine("Width: " + values[8]);
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (applianceType.Equals("Vacuum", StringComparison.OrdinalIgnoreCase))
                        {
                            foreach (string line in lines3)
                            {
                                if (line.StartsWith("2"))
                                {
                                    string[] values = line.Split(';');
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Grade: " + values[6]);
                                    Console.WriteLine("Battery voltage: " + values[7]);
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (applianceType.Equals("Microwave", StringComparison.OrdinalIgnoreCase))
                        {
                            foreach (string line in lines3)
                            {
                                if (line.StartsWith("3"))
                                {
                                    string[] values = line.Split(';');
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    Console.WriteLine("Capacity: " + values[6]);
                                    Console.WriteLine("Room type: " + values[7]);
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (applianceType.Equals("Dishwasher", StringComparison.OrdinalIgnoreCase))
                        {
                            foreach (string line in lines3)
                            {
                                if (line.StartsWith("3") || line.StartsWith("4"))
                                {
                                    string[] values = line.Split(';');
                                    Console.WriteLine("ItemNumber: " + values[0]);
                                    Console.WriteLine("Brand: " + values[1]);
                                    Console.WriteLine("Quantity: " + values[2]);
                                    Console.WriteLine("Wattage: " + values[3]);
                                    Console.WriteLine("Color: " + values[4]);
                                    Console.WriteLine("Price: " + values[5]);
                                    if (line.StartsWith("3"))
                                    {
                                        Console.WriteLine("Place settings: " + values[6]);
                                    }
                                    if (line.StartsWith("4"))
                                    {
                                        Console.WriteLine("Capacity: " + values[6]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid appliance type. Please enter Refrigerator, Vacuum, Microwave, or Dishwasher.");
                        }
                        break;

                    case 4:
                        // Prompt user for number of random appliances
                        Console.Write("Enter number of random appliances: ");
                        int numAppliances = int.Parse(Console.ReadLine());

                        // Generate and display random appliances
                        Random rnd = new Random();
                        string[] allLines = File.ReadAllLines("C:\\Users\\nichi\\OneDrive\\Desktop\\OOP2\\Appliance Assignment\\Appliance Assignment\\appliances.txt");
                        for (int i = 0; i < numAppliances; i++)
                        {
                            int randomIndex = rnd.Next(allLines.Length);
                            string line = allLines[randomIndex];
                            string[] values = line.Split(';');
                            if (line.StartsWith("1"))
                            {
                                Console.WriteLine("Brand: " + values[1]);
                                Console.WriteLine("Quantity: " + values[2]);
                                Console.WriteLine("Wattage: " + values[3]);
                                Console.WriteLine("Color: " + values[4]);
                                Console.WriteLine("Price: " + values[5]);
                                Console.WriteLine("Number of Doors: " + values[6]);
                                Console.WriteLine("Height: " + values[7]);
                                Console.WriteLine("Width: " + values[8]);
                            }
                            else if (line.StartsWith("2"))
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
                            else if (line.StartsWith("3"))
                            {
                                Console.WriteLine("ItemNumber: " + values[0]);
                                Console.WriteLine("Brand: " + values[1]);
                                Console.WriteLine("Quantity: " + values[2]);
                                Console.WriteLine("Wattage: " + values[3]);
                                Console.WriteLine("Color: " + values[4]);
                                Console.WriteLine("Price: " + values[5]);
                                Console.WriteLine("Power: " + values[6]);
                                Console.WriteLine("Capacity: " + values[7]);
                            }
                            else if (line.StartsWith("4"))
                            {
                                Console.WriteLine("ItemNumber: " + values[0]);
                                Console.WriteLine("Brand: " + values[1]);
                                Console.WriteLine("Quantity: " + values[2]);
                                Console.WriteLine("Wattage: " + values[3]);
                                Console.WriteLine("Color: " + values[4]);
                                Console.WriteLine("Price: " + values[5]);
                                Console.WriteLine("Feature: " + values[6]);
                                Console.WriteLine("SoundRating: " + values[7]);
                            }
                            else if (line.StartsWith("5"))
                            {
                                Console.WriteLine("ItemNumber: " + values[0]);
                                Console.WriteLine("Brand: " + values[1]);
                                Console.WriteLine("Quantity: " + values[2]);
                                Console.WriteLine("Wattage: " + values[3]);
                                Console.WriteLine("Color: " + values[4]);
                                Console.WriteLine("Price: " + values[5]);
                                Console.WriteLine("Feature: " + values[6]);
                                Console.WriteLine("SoundRating: " + values[7]);
                            }
                            Console.WriteLine();
                        }
                        break;


                    case 5:
                        // Save and exit
                        Console.WriteLine("Saving and exiting...");
                        // write all changes to the appliances.txt file
                        // ...
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
                        break;
                }

                Console.ReadLine();
            }
        }


