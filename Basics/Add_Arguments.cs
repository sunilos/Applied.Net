using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreJavaTest.exercise4._14
{
    internal class Add_Arguments
    {
        public static void Add(String[] args)
        {
             int a = Int32.Parse(args[0]);
             int b = Int32.Parse(args[1]);
             int sum = a + b;
             Console.WriteLine("Sum is " + sum);
}
    }
}
