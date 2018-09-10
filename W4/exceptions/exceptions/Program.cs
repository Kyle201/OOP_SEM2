using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Enter A Number: ");
                int x = Int32.Parse(Console.ReadLine());
                int sum = 0;
                int y;
                while (x != 0)
                {
                    y = x % 10;
                    sum = sum + y;
                    x = x / 10;

                }
                Console.WriteLine(sum);
                Console.ReadLine();

                if (x <= 0)
                {
                    throw new ZeroExceptions(); 
                }

                if (x < 15)
                {
                    throw new fifteenExceptions();
                }

            }
            catch (FormatException) 
            {
                

            }
            
            catch (ZeroExceptions ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (fifteenExceptions ax)
            {
                Console.WriteLine(ax.Message);
                Console.ReadLine();
            }

        }
    }

    public class ZeroExceptions : Exception
    {
        public string message = "Must Be Higher Then 0";
      
    }
    public class fifteenExceptions : Exception
    {
        public string message = "Must Be Lower Then 15";

    }
}

