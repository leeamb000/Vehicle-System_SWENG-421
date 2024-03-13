using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class SUV : VehicleAbs
    {

        private double MSRP = 34000;
        private string VinNumber = "19888FL3ETW";
        private string ModelName = "SUV";
        private string Color = "Unselected";

        public SUV()
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
