using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Trim
{
    public class Limited : Truck
    {
        public Limited()
        {
            description = "Limited Trim";
        }

        public override double Cost()
        {
            return 59999;
        }
    }
}
