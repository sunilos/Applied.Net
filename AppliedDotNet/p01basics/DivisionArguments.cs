using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class DivisionArguments
    {
        public static void Test(String[] args)
        {
            int a = Int32.Parse(args[0]);
            int b = Int32.Parse(args[1]);
            double div = a / b;
            Console.WriteLine("Division is " + div);
        }
    }
}