using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class VehicleFactory : VehicleFactoryIF
    {
        public VehicleIF createVehicle(string type)
        {
            Type t = Type.GetType($"VehicleSystem.{type}");
            return (VehicleIF)Activator.CreateInstance(t);

        }
    }
}
