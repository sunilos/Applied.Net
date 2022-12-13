using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class Tables
    {
        public static void Addcount(string[] args)
        {
            int a = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine();
                for (int j = 2; j < 11; j++)
                {
                    a = i * j;
                    Console.Write(a + "\t");
                }
            }
        }
    }
}