using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class SeatCover : AccessoryAbs
    {
        public void getCover()
        { }

        private double price = 20.00;
        public override double getPrice()
        {
            return price;
        }
   
    }
}
