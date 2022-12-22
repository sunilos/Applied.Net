using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /** 
     * Reads data from a text file
     * @Author SunilOS
     */
    public class ReadFile
    {
        public static void Test()
        {
            FileStream f = new FileStream("C:\\Users\\ASUS\\OneDrive\\Documents\\Test.txt", FileMode.Open);
            StreamReader input = new StreamReader(f);
            String line = input.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = input.ReadLine();
            }
            f.Close();
        }
    }
}