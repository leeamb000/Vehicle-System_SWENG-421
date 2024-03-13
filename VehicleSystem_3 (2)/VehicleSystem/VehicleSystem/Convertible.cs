using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Convertible : VehicleDecorator
    {
        private double MSRP = 60000;
        private string VinNumber = "1HGCG16572A063791";
        private string ModelName = "Convertible";
        private string Color = "Unselected";

        public Convertible(VehicleIF vif, AccessoryIF aif, CustomPartsIF cpif) : base(vif, aif, cpif)
        {
        }

        public Convertible(VehicleIF vif, AccessoryIF aif) : base(vif, aif)
        {
        }
        public Convertible(VehicleIF vif, CustomPartsIF cpif) : base(vif, cpif)
        {
        }

        public Convertible()
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
