using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping == true)

            {
                Console.WriteLine("Choose an Attack");
                Console.WriteLine("1. Melee Attack!");
                Console.WriteLine("2. Ranged Attack!");
                Console.WriteLine("");
                int Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        {
                            Console.WriteLine("You Have Chosen a Melee Attack");
                            Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("You Have Chosen a Ranged Attack");
                            Console.ReadLine();
                            break;

                        }

                    case 3:
                        {
                            Console.WriteLine("Exiting loop");
                            Console.ReadLine();
                            keepLooping = false;
                            break;
                        }
                }
            }

        }
    }
}
