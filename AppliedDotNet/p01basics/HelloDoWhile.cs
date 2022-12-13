using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    public class HelloDoWhile
    {
        public static void DoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i + " Hello C#");
                i++;

            } while (i < 5);
        }
    }
}