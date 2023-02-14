using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Assignment
{
    internal class Microwave : Appliance
    {
        public int RoomType { get; set; }
        public double Capacity { get; set; }

        public Microwave(long itemnumber, string brand, int quantity, string wattage, string color, double price, int color, int roomtype, double capacity) : base(itemnumber, brand, quantity, wattage, color, price)
        {
            this.SoundRating { get; set; }
            this.Feature { get; set; }
        }
}
