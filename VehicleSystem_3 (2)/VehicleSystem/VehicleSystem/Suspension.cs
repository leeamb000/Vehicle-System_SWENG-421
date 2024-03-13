using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem

{//sub-systems such as front, rear suspension and entire suspension 
    //is a part of the composite design pattern
    public class Suspension : CompositeComponentAbs
    {
        private string Name = "None";
        private List<CompositeComponentIF> Components = new List<CompositeComponentIF>();
        private double Price = 900.00;

        public double GetPrice()
        {
            return Price;
        }

        public Suspension()
        {
           
        }
        //second constructor for the composite pattern
        public Suspension(string name) : base(name)
        {

        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        //will add a component
        public void AddComponent(CompositeComponentIF component)
        {
            Components.Add(component);
        }
        //will remove a component
        public void RemoveComponent(CompositeComponentIF component)
        {
            Components.Remove(component);
        }

        public new string Operation()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} contains:");

            foreach (CompositeComponentIF component in Components)
            {
                builder.Append("\n");
                builder.Append(component.Operation());
            }

            return builder.ToString();
        }

        //returns the component location from the componets array
        public new CompositeComponentAbs GetComponent(int componentLocation)
        {
            return (CompositeComponentAbs)Components.ElementAt(componentLocation);
        }
    }
}
