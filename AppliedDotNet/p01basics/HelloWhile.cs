using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Example class for While Loop
     * @Author SunilOS
     */
    public class HelloWhile
    {
        public static void Test()
        {
            Boolean isAlive = true;
            int round = 0;
            while (isAlive)
            {
                Console.WriteLine("Basanti will dance");
                round++;
                if (round > 500)
                {
                    isAlive = false;
                }
            }
        }
    }
}