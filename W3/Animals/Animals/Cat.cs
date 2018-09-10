using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Mammal
    {

        public Cat(string name, int life, string hunger, int legs)
        : base(name, life, hunger, legs)
        {
      
        }

        public override string Move()
        {
            return "Rustle";
        }

        public override string Poop()
        {
            return "Small";
        }

        public override string Feed()
        {
            return "Munch";
        }

    }
}
