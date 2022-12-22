using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**  
     * Copy a Binary File
     * @Author SunilOS
     */
    public class CopyFile
    {
        public static void Test()
        {
            String source = "C:\\Users\\ASUS\\OneDrive\\Documents\\Test.txt"; String target = "C:\\Users\\ASUS\\OneDrive\\Documents\\Test1.txt";

            FileStream f = new FileStream(source, FileMode.Open, FileAccess.Read);

            StreamReader input = new StreamReader(f);

            FileStream fs = new FileStream(target, FileMode.Create);

            StreamWriter output = new StreamWriter(fs);

            String line = input.ReadLine(); //Read from keyboard

            while (line != null)
            {
                output.WriteLine(line);
                line = input.ReadLine();
            }
            input.Close();
            output.Close();

            Console.WriteLine("Done");
        }
    }
}