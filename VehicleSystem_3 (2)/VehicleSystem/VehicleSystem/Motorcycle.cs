using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Motorcycle : VehicleDecorator
    {
        private double MSRP = 15000;
        private string VinNumber = "1FMCU0DG1AKB96475";
        private string ModelName = "Motorcycle";
        private string Color = "Unselected";

        public Motorcycle(VehicleIF vif, AccessoryIF aif, CustomPartsIF cpif) : base(vif, aif, cpif)
        {
        }

        public Motorcycle(VehicleIF vif, AccessoryIF aif) : base(vif, aif)
        {
        }

        public Motorcycle(VehicleIF vif, CustomPartsIF cpif) : base(vif, cpif)
        {
        }

        public Motorcycle() 
        { }

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
