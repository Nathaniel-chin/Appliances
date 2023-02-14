using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Assignment
{
    internal class Dishwasher : Appliance
    {
        public int SoundRating { get; set; }
        public int Feature { get; set; }

        public Dishwasher(long itemnumber, string brand, int quantity, string wattage, string color, double price, int color, double height, double width) : base(itemnumber, brand, quantity, wattage, color, price)
        {
            this.SoundRating { get; set; }
            this.Feature { get; set; }
    }

}
