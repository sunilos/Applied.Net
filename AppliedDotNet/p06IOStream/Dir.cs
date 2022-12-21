using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**
     * Reads a Text File charter by charter and by char array 
     * @Author SunilOS
     */
    public class Dir
    {
        public static void Test()
        {
            DirectoryInfo d = new DirectoryInfo("C:/Documents");
            if (d.Exists)
            {
                DirectoryInfo[] dirs = d.GetDirectories();
                for (int i = 0; i < dirs.Length; i++)
                {
                    Console.WriteLine("DIR : " + dirs[i].Name);
                }
                FileInfo[] files = d.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine("Files : " + files[i].Name);
                }
            }
        }
    }
}
