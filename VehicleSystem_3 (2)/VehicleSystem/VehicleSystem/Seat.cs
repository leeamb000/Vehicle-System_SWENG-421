using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Seat : CustomPartsAbs
    {
        private double Price = 1500.00;

        public override double GetPrice()
        {
            return Price;
        }
    }
}
