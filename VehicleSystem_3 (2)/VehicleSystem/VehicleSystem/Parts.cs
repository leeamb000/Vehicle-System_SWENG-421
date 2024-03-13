using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    //springs, schock absorbers, struts as leafs
    internal class Parts : CompositeComponentIF
    {
        private string name;

        public Parts(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public string Operation()
        {
            return $"{name} is part of the suspension system.";
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
