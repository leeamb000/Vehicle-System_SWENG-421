using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Truck : VehicleDecorator
    {
        private double MSRP = 45000;
        private string VinNumber = "1G1RA6E41EU105562";
        private string ModelName = "Truck";
        private string Color = "Unselected";

        public Truck(VehicleIF vif, AccessoryIF aif, CustomPartsIF cpif) : base(vif, aif, cpif)
        {
        }

        public Truck(VehicleIF vif, AccessoryIF aif) : base(vif, aif)
        {
        }

        public Truck(VehicleIF vif, CustomPartsIF cpif) : base(vif, cpif)
        {
        }

        public Truck()
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
