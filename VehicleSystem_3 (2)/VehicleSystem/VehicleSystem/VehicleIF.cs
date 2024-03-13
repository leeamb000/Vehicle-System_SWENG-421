using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    public interface VehicleIF
    {
        void BuildVehicle(VehicleIF vif);
        void SetPaintColor(string color);

        void SetTransmission(string type);
        void SetFuelType(string type);
        void setOilChange(bool t);
        void setRotateTires(bool t);
        void setCheckBrakes(bool t);
        string GetModelName();
        double GetPrice();
        string GetVinNumber();
        string GetPaintColor();
        string GetTransmission();
        string GetFuelType();
        string GetParts();
        string GetAccessories();
        void AcceptMaintenanceVisitor(MaintenanceVisitorIF visitor);
        void SetSuspension(string type);
        string GetSuspension();
        bool getOilChange();
        bool getRotateTires();
        bool getCheckBrakes();
    }
}
