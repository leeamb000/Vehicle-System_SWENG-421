using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class MaintanceVisitor : MaintenanceVisitorIF
    {
        Form1 form1 = new Form1();
            public void PerformOilChange(VehicleIF v)
            { 
                form1.textBox1.AppendText($"Performing oil change on {v.GetModelName()}");
                form1.textBox1.AppendText(Environment.NewLine);
            }

            public void RotateTires(VehicleIF v)
            {
                form1.textBox1.AppendText($"Rotating tires on {v.GetModelName()}");
                form1.textBox1.AppendText(Environment.NewLine);
            }

            public void CheckBrakes(VehicleIF v)
            {
                form1.textBox1.AppendText($"Checking brakes for {v.GetModelName()}");
                form1.textBox1.AppendText(Environment.NewLine);
            }
    }
}
