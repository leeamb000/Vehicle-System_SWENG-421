using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class TirePressureMonitor : AccessoryAbs
    {
        private double price = 150.00;
        public override double getPrice()
        {
            return price;
        }
    }
}
