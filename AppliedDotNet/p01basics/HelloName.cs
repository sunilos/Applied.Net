using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * A simple program to print runtime argument with Hello.  
     * @Author SunilOS   
     */
    public class HelloName
    {
        public static void Test(String[] args)
        {
            Console.WriteLine("Hello " + args[0]);
        }
    }
}