using System;

namespace DesignPuzzle.Impl
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I swing my sword!");
        }
    }
}
