using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /** 
     * Reads data line by line from a text file
     * @Author SunilOS
     */
    public class ReadAllLine
    {
        public static void Test()
        {
            string[] lines = new string[10];
            for (int i = 0; i < 10; i++)
            {
                lines[i] = String.Format("This is line number {0}", i);
            }
            File.WriteAllLines(@"C:\Users\ASUS\OneDrive\Documents\Test.txt", lines);

            foreach (string line in File.ReadAllLines(@"C:\Users\ASUS\OneDrive\Documents\Test.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}