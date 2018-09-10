using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Mammal : Animal
    {
        public int Legs;

        public Mammal(string name, int life, string hunger, int legs) 
            : base(name, life, hunger)
        {
            this.Legs = legs;
        }         
        
    }
}
