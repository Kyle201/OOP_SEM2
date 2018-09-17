using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    abstract class Weapon
    {
        public int BaseDamage { get; set; }
        public int BaseRange { get; set; }
        public int ActionPoints { get; set; }
        public int CriticalDamage { get; set; }
        public int PokeAttack { get; set; }
        public int AttackDamage { get; set; }


        public Weapon(int baseD, int baseR, int action, int crit, int poke, int attack)
        {
            this.BaseDamage = baseD;
            this.BaseRange = baseR;
            this.ActionPoints = action;
            this.CriticalDamage = crit;
            this.PokeAttack = poke;
            this.AttackDamage = attack;
        }

        public int CritDamage()
        {
            return BaseDamage * 2;
        }
    }

}
