using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Assignment
{
    internal class Vacuum
    {
        public int BatteryVoltage { get; set; }
        public double Grade { get; set; }

        public Microwave(long itemnumber, string brand, int quantity, string wattage, string color, double price, int color, double batteryvoltage, double grade) : base(itemnumber, brand, quantity, wattage, color, price)
        {
            this.BatteryVoltage { get; set; }
            this.Grade { get; set; }
        }
    }
}
