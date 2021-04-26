using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Truck
    {
        public string description = "Unknown Truck.";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
