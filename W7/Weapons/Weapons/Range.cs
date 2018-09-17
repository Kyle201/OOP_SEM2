using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    abstract class Range : Weapon
    {
        public Range (int baseD, int baseR, int action, int crit, int poke, int attack)
            : base(baseD, baseR, action, crit, poke, attack)
        {

        }

        public int DamageBase()
        {
            return BaseDamage;
        }

      
    }
}
