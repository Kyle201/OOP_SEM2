using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        public string Name;
        public int Life;
        public string Hunger;


        public Animal(string name, int life, string hunger)
        {
            this.Name = name;
            this.Life = life;
            this.Hunger = hunger;

        }

        public abstract string Move();
        public abstract string Poop();
        public abstract string Feed();
    }
}
