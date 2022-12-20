using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * This example is for taking run time arguments, then parse them into integer type for addition.
     * @Author SunilOS
     */
    public class AddArguments
    {
        public static void Test(String[] args)
        {
            int a = Int32.Parse(args[0]);
            int b = Int32.Parse(args[1]);
            int sum = a + b;
            Console.WriteLine("Sum is " + sum);
        }
    }
}