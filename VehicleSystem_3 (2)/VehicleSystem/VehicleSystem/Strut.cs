using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    class Strut : CompositeComponentAbs
    {
        string Name;

        public Strut()
        {
        }

        public Strut(string name) : base(name) { }
        public new string Operation()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Part component {Name}:");

            return builder.ToString();
        }
    }
}
