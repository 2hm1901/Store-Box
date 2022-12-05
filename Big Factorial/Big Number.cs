using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
    internal class Big_Number
    {
        public BigInteger value { get; set; }

        public Big_Number()
        {

        }
        public void calculateBigFactorial()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
