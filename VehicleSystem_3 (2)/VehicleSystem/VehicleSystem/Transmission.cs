using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Transmission : CustomPartsAbs
    {
        private double Price = 3000.00;
        string type;

        public override double GetPrice()
        {
            return Price;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getType()
        {
            return type;
        }
    }
}
