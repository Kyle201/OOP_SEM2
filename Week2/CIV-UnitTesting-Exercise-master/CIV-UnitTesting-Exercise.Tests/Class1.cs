using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIV_UnitTesting_Exercise.Tests
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void Test1()
        {
            Assert.AreEqual(1, 1);
        }

        public void FibCheck()
        {
            int num = 1;
            int actual = num;

            actual = RecursiveCalculations.FibCheck(num);
            Assert.();
        }

     
    }
   
  


}
