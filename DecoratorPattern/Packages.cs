using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Packages : Truck
    {
        public Truck _truck;
        public abstract string GetDescription();
    }
}
