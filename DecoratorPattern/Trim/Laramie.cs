using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Trim
{
    public class Laramie : Truck
    {
        public Laramie()
        {
            description = "Laramie Trim";
        }

        public override double Cost()
        {
            return 49999;
        }
    }
}
