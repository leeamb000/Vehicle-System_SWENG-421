using System.Reflection;
using System;

namespace VehicleSystem
{
    internal interface UserIF
    {
        void addAccessory();
        VehicleIF UseFactory(String name);
   
    }
}