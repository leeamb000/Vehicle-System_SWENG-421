using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VehicleSystem
{
    public abstract class VehicleAbs : VehicleIF
    {
       
        protected string ModelName { get; set; }
        protected string VinNumber { get; }
        protected double MSRP { get; }
        protected string Color = "Unselected";
        protected string Transmission = "Unselected";
        protected string FuelType = "Unselected";
        protected CompositeComponentIF suspension = new Suspension();
        protected CompositeComponentIF carComponent;
        public Boolean oilChange = false, rotateTires = false, checkBrakes = false;


        public VehicleAbs() {
           
        }
        public virtual double GetPrice()
        {
            return MSRP;
        }

        public virtual string GetVinNumber()
        {
            return this.VinNumber;
        }

        public virtual void SetPaintColor(string Color)
        {
            this.Color = Color;
        }

        public virtual void SetTransmission(string type)
        {
            this.Transmission = type;
        }
        public virtual void SetFuelType(string type)
        {
            this.FuelType = type;
        }

        public virtual void setOilChange(bool t)
        {
            this.oilChange = t;
        }
        public virtual void setRotateTires(bool t)
        {
            this.rotateTires = t;
        }
        public virtual void setCheckBrakes(bool t)
        {
            this.checkBrakes = t;
        }
        public virtual bool getOilChange()
        { return this.oilChange; }
        public virtual bool getRotateTires()
        { return this.rotateTires; }
        public virtual bool getCheckBrakes()
        { return this.checkBrakes; }

        public virtual string GetPaintColor()
        {
            return this.Color;
        }
        public virtual string GetTransmission()
        {
            return this.Transmission;
        }
        public virtual string GetFuelType()
        {
            return this.FuelType;
        }

        public void BuildVehicle(VehicleIF vehicle)
        {
            ResultForm form = new ResultForm();

            form.textBox1.AppendText($"The Vehicle's...");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Model is {GetModelName()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"VIN number is {GetVinNumber()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Recomended MSRP is ${GetPrice()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Color is {GetPaintColor()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Fuel type is {GetFuelType()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Transmission type is {GetTransmission()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Suspension type is {suspension.GetName()}.");
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Customized parts added: {vehicle.GetParts().Replace("None, ", "")}."); 
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Accessories added: {vehicle.GetAccessories().Replace("None, ", "")}."); 
            form.textBox1.AppendText(Environment.NewLine);

            form.textBox1.AppendText($"Selected maintenance completed: ");
            form.textBox1.AppendText(Environment.NewLine);
            if (vehicle.getOilChange()) 
            {
                form.textBox1.AppendText($"Oil Changed");
                form.textBox1.AppendText(Environment.NewLine);
            }
            if (vehicle.getRotateTires())
            {
                form.textBox1.AppendText($"Rotated Tires");
                form.textBox1.AppendText(Environment.NewLine);
            }
            if (vehicle.getCheckBrakes())
            {
                form.textBox1.AppendText($"Checked Brakes");
                form.textBox1.AppendText(Environment.NewLine);
            }
            if (!vehicle.getOilChange() && !vehicle.getRotateTires() && !vehicle.getCheckBrakes())
            {
                form.textBox1.AppendText($"None");
                form.textBox1.AppendText(Environment.NewLine);
            }

            form.ShowDialog(); 
        }

        public void SetModelName(string ModelName)
        {
            this.ModelName = ModelName;
        }
        public abstract string GetModelName();

        public abstract string GetParts();
        public abstract string GetAccessories();

        public void AcceptMaintenanceVisitor(MaintenanceVisitorIF visitor)
        {
            visitor.PerformOilChange(this);
            visitor.RotateTires(this);
            visitor.CheckBrakes(this);
            // Call other maintenance operations as needed
        }

        public void SetSuspension(string type)
        {
            suspension = new Suspension();
            suspension.SetName(type);
        }

        //overloaded SetSuspension that uses name for the composite pattern
        public void SetSuspension(string type, string name)
        {
            suspension = new Suspension(name);
            suspension.SetName(type);
        }
        public string GetSuspension()
        {
            return suspension.GetName();
        }

    }
}
