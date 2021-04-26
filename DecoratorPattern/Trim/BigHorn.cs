using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Trim
{
    public class BigHorn : Truck
    {
        public BigHorn()
        {
            description = "BigHorn Trim";
        }

        public override double Cost()
        {
            return 39999;
        }
    }
}
