using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class MathMethods
    {
        public static void Test()
        {

            Console.WriteLine("Math functions");
            Console.WriteLine(" Max 2,5 - " + Math.Max(2, 5));
            Console.WriteLine(" Min 2,5 - " + Math.Min(2, 5));
            Console.WriteLine(" Absolute 3.7 - " + Math.Abs(3.7));
            Console.WriteLine(" Exp 10 - " + Math.Exp(10));
            Console.WriteLine(" Square Root- " + Math.Sqrt(4));
        }
    }
}