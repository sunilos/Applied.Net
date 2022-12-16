using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /* Example class for DO-While Loop
     * @Author SunilOS
     */
    public class HelloDoWhile
    {
        public static void Test()
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