using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Assignment
{
    internal class Refrigerator : Appliance
    {
        public int NumberOfDoors { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Refrigerator(long itemnumber, string brand, int quantity, string wattage, string color, double price, int numberofdoors, double height, double width) : base(itemnumber, brand, quantity, wattage, color, price)
        {
            this.NumberOfDoors = numberofdoors;
            this.Height = height;
            this.Width = width;
        }
    }

}
