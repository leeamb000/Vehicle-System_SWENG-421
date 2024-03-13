using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Minivan : VehicleAbs
    {
        private double MSRP = 50000;
        private string VinNumber = "1254FL88ATE";
        private string ModelName = "Minivan";
        private string Color = "Unselected";
        public Minivan()
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
