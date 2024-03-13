using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal abstract class AccessoryAbs : AccessoryIF
    {
        private double price;
        public virtual double getPrice()
        {
            return price;
        }
    }
}
