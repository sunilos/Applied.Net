using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**
     * Write a Text File charter by charter and by char array. 
     * @Author SunilOS
     */
    public class Attri
    {
        public static void Test()
        {
            String fileName = "C:\\Users\\ASUS\\OneDrive\\Documents\\Test.txt";
            FileInfo f = new FileInfo(fileName);
            if (f.Exists)
            {
                Console.WriteLine("Name: " + f.FullName);
                Console.WriteLine("Extention : " + f.Extension);
                Console.WriteLine("Directory : " + f.DirectoryName);
                Console.WriteLine("Is Readonly " + f.IsReadOnly);
                Console.WriteLine("Created at " + f.CreationTime);
                Console.WriteLine("Modified at " + f.LastWriteTime);
                Console.WriteLine("Length " + f.Length + "bytes long.");
            }
        }
    }
}