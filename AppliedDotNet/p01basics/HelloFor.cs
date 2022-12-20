using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Example class for For Loop
     * @Author SunilOS
     */
    public class HelloFor
    {
        public static void Test()
        {
            for (int hits = 1; hits <= 5; hits++)
            {
                Console.WriteLine("Shot Balloon");
            }
        }
    }
}