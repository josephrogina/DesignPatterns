using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPuzzle
{
    public abstract class Character
    {
        public IWeaponBehavior _weaponBehavior;

        public Character()
        {

        }

        public void SetWeapon(IWeaponBehavior weaponBehavior)
        {
            _weaponBehavior = weaponBehavior;
        }

        public virtual void Fight() { }
    }
}
