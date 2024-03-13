using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Sedan : VehicleAbs
    {
        private double MSRP = 40000;
        private string VinNumber = "19554FL3ATW";
        private string ModelName = "Sedan";
        private string Color = "Unselected";

        public Sedan()
        {
            
        }

        public override void SetPaintColor(string Color)
        {
            this.Color = Color;
        }

        public override string GetPaintColor()
        {
            return this.Color;
        }

        public override double GetPrice()
        {
            return MSRP;
        }

        public override string GetVinNumber()
        {
            return VinNumber;
        }

        public override string GetModelName()
        {
            return ModelName;
        }

        public override string GetParts()
        {
            return "None";
        }

        public override string GetAccessories()
        {
            return "None";
        }
    }
}
