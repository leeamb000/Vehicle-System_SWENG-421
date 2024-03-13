using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class CarAlarm : AccessoryAbs
    {
        private double price = 300.00;
        public override double getPrice()
        {
            return price;
        }
    }
}
