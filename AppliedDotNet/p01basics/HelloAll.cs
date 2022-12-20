using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Program to print runtime argument list
     * @Author SunilOS
     */
    public class HelloAll
    {
        public static void Test(String[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(i + " = Hello " + args[i]);
            }
        }
    }
}
