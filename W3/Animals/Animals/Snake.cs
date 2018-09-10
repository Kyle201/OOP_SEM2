using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Snake : Reptile
    {

        public Snake(string name, int life, string hunger, string scale)
                    : base(name, life, hunger, scale)
        {

        }

        public override string Move()
        {
            return "Shoo";
        }

        public override string Poop()
        {
            return "Lines";
        }

        public override string Feed()
        {
            return "Chomp";
        }

    }
}
