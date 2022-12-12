using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreJavaTest.exercise4._14
{
    internal class HelloWhile
    {
        public static void loops()
        {
            Boolean isAlive = true;
            int round = 0;
            while (isAlive)
            {
                Console.WriteLine("Basanti will dance");
                round++;
                if(round > 500)
                {
                    isAlive = false;
                }
            }
        }
        
    }
    }
