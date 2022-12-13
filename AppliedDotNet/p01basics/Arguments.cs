using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class Arguments
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sum(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void modulus(int a, int b)
        {
            Console.WriteLine(a % b);
        }
    }
}