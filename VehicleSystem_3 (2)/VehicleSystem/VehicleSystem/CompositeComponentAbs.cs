using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    public abstract class CompositeComponentAbs : CompositeComponentIF
    {
        string Name = "Unselected";

        public CompositeComponentAbs() { }
        public CompositeComponentAbs(string name)
        {
            Name = name;
        }

        public string Operation()
        {
            throw new NotImplementedException();
        }

        public CompositeComponentAbs GetComponent(int component)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string name)
        {
            this.Name= name;
        }
    }
}
