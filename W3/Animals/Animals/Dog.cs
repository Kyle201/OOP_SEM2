using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Mammal
    {

        public Dog(string name, int life, string hunger, int legs)
        : base(name, life, hunger, legs)
        {
   
        }
        public override string Move()
        {
            return "Woof";
        }

        public override string Poop()
        {
            return "Big";
        }

        public override string Feed()
        {
            return "Slurp";
        }


    }
}
