using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Reptile : Animal
    {
        public string Scales;

        public Reptile(string name, int life, string hunger, string scales)
                    : base(name, life, hunger)
        {
            this.Scales = scales;
        }

    }
}
