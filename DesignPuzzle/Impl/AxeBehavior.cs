using System;

namespace DesignPuzzle.Impl
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I swing my Axe!");
        }
    }
}
