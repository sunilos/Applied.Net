using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class HelloFor
    {
        public static void For()
        {
            for (int hits = 1; hits <= 5; hits++)
            {
                Console.WriteLine("Shot Balloon");
            }
        }
    }
}