using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Program to get ReturnValues with Arguments 
     * @Author SunilOS
     */
    public class ReturnValuesArguments
    {
        public static void Test(String[] args)
        {
            int a = Int32.Parse(args[0]);
            int b = Int32.Parse(args[1]);
            double div = getDivision(a, b);
            Console.WriteLine("Division is " + div);
        }
        public static double getDivision(int a, int b)
        {
            double div = a / b;
            return div;
        }
    }
}