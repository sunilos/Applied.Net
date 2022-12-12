using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class HelloAll
    {
        public static void RunTime(String[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(i + " = Hello " + args[i]);
            }
        }
    }
}
