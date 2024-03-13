using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSystem
{
    internal class VehicleDecorator : VehicleAbs
    {
        public VehicleIF vif;
        public AccessoryIF aif;
        public CustomPartsIF cpif;
        private string lastAdded;

        //contructors
        public VehicleDecorator(VehicleIF vif, AccessoryIF aif, CustomPartsIF cpif)
        {
            this.vif = vif;
            this.aif = aif;
            this.cpif = cpif;
        }

        public VehicleDecorator(VehicleIF vif, AccessoryIF aif)
        {
            this.vif = vif;
            this.aif = aif;

            lastAdded = "a";
        }

        public VehicleDecorator(VehicleIF vif, CustomPartsIF cpif)
        {
            this.vif = vif;
            this.cpif = cpif;

            lastAdded = "c";
        }

        public VehicleDecorator()
        { }

        //misc
        public override double GetPrice()
        {
            return vif.GetPrice();
        }

        public override string GetVinNumber()
        {
            return vif.GetVinNumber();
        }

        public override string GetModelName()
        {
            return vif.GetModelName();
        }

        public override string GetParts()
        {
            if (lastAdded == "c")
            {
                return vif.GetParts() + ", " + cpif.GetType().Name;
            }
            else
            {
                return vif.GetParts();
            }
        }

        public override string GetAccessories()
        {
            if (lastAdded == "a")
            {
                return vif.GetAccessories() + ", " + aif.GetType().Name;
            }
            else
            {
                return vif.GetAccessories();
            }
        }

    }
}
