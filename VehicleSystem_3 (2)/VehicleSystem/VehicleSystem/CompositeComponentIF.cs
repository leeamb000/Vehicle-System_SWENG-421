using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    public interface CompositeComponentIF
    {
        string Operation();

        string GetName();
        void SetName(string name);
    }
}
