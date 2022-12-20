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
    public class HelloAllDefineMethods
    {
        
        public static void Test(String[] args)
        {
            PrintAll(args);
        }// main
        public static void PrintAll(String[] args)
        {
            int size = args.Length;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine((i + 1) + " = Hello " + args[i]);
            }
        }
    }
}