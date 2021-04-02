using System;

namespace DesignPuzzle.Impl
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I shoot an arrow with my bow!");
        }
    }
}
