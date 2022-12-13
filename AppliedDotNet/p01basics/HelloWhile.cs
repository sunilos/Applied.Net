using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class HelloWhile
    {
        public static void Loops()
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