using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Program to get the Date
    */
    public class NormalDate
    {
        public static void Test()
        {
            DateOnly date = new DateOnly();

            Console.WriteLine(date);
        }
    }
}