namespace VehicleSystem
{
    public interface MaintenanceVisitorIF
    {
        void CheckBrakes(VehicleIF vehicle);
        void PerformOilChange(VehicleIF vehicle);
        void RotateTires(VehicleIF vehicle);
    }
}