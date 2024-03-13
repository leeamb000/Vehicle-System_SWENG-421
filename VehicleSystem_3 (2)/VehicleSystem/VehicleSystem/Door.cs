using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Door : CustomPartsAbs
    {
        private double Price = 2000.00;

        public override double GetPrice()
        {
            return Price;
        }

    }
}
