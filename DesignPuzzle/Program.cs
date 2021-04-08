using System;

namespace DesignPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.SetWeapon(king._weaponBehavior);
            king.Fight();
            //TODO: I would not normally do it this way, but for the excersice it's fine.
            king._weaponBehavior.UseWeapon();
        }
    }
}
