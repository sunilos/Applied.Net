using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**
     * Writes to a Text File. You can write character, char array and string.
     * @Author SunilOS
     */
    public class WriteFile
    {
        public static void Test()
        {
            FileStream fs = new FileStream("C:/Test.txt", FileMode.Create);
            StreamWriter output = new StreamWriter(fs);
            String line = Console.ReadLine(); //Read from keyboard
            while (!line.Equals("quit"))
            {
                output.WriteLine(line);
                line = Console.ReadLine();
            }
            output.Close();

        }
    }
}
