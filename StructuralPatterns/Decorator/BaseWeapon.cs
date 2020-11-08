using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    class BaseWeapon : Weapon
    {
        public BaseWeapon()
        {
            damage = 50;
        }

        public override void shot()
        {
            Console.WriteLine($"Shot for {damage}");
        }
    }
}
