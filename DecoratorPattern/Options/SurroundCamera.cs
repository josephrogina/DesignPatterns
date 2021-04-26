using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Options
{
    public class SurroundCamera : Packages
    {
        public SurroundCamera(Truck truck)
        {
            _truck = truck;
        }

        public override double Cost()
        {
            return _truck.Cost + 1695;
        }

        public override string GetDescription()
        {
            return _truck.GetDescription() + " with Surround Camera";
        }
    }
}
