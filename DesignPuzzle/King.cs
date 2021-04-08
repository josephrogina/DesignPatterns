using DesignPuzzle.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPuzzle
{
    public class King : Character
    {
        public King()
        {
            _weaponBehavior = new BowAndArrowBehavior();
        }
        public override void Fight()
        {
            Console.WriteLine("The king fights!");
        }
    }
}
