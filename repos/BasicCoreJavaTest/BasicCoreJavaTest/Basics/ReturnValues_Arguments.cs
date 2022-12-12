using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreJavaTest.exercise4._14
{
    internal class ReturnValues_Arguments
    {
        public static void Return(String[] args)
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
