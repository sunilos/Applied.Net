using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**  
     * Test Copy a Binary File
     * @Author SunilOS
     */
    public class TestCopyFile
    {
        public static void Test()
        {
            FileInfo MyFile = new FileInfo(@"C:\Users\ASUS\OneDrive\Documents");
            //MyFile.Create();
            MyFile.CopyTo(@"C:\Users\ASUS\OneDrive\Documents");
            //or
            MyFile.CopyTo(@"C:\Users\ASUS\OneDrive\Documents", true);

            Console.WriteLine("Done");
        }
    }
}