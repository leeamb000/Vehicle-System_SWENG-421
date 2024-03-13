using System;

namespace VehicleSystem
{
    internal class User : UserIF
    {

        private VehicleFactoryIF factory = new VehicleFactory();
        public User()
        {
        }

        public VehicleIF UseFactory(String type)
        {
            return factory.createVehicle(type);
        }

        public void addAccessory()
        {
            factory.createVehicle("VehicleDecorator");
        }
    }
}
