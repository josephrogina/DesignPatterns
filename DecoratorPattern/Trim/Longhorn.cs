using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Trim
{
    public class Longhorn : Truck
    {
        public Longhorn()
        {
            description = "Longhorn Trim";
        }

        public override double Cost()
        {
            return 55999;
        }
    }
}
