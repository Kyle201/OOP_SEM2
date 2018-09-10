using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class cookie
    {
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Topping { get; set; }
        public DateTime CreatedDate { get; private set; }
        public cookie(string color, string Shape, string topping, DateTime createdDate)
        {
            this.Color = color;
            this.Shape = Shape;
            this.Topping = topping;
            this.CreatedDate = createdDate;
        }

        public void BakeCookie(int secondsinOven)
        {
            Console.WriteLine("Baking Cookie for:" + secondsinOven + "seconds.");

        }

        public bool OutOfDate(int daysForExpiry)
        {
            if(CreatedDate.AddDays(daysForExpiry) >= DateTime.Now)
            {
                return true;
            }

            return false;
        }

    }
}
