using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    class Spring : CompositeComponentAbs
    {
        string Name;

        public Spring(string name) : base(name) { }
        public new string Operation()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Part component {Name}:");

            return builder.ToString();
        }
    }
}
