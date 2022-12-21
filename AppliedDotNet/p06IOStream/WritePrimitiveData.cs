using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /** 
     * Writes Primitive Data to a binary stream.
     * @Author SunilOS
     */
    public class WritePrimitiveData
    {
        public static void Test()
        {
            FileStream fs = new FileStream("C:/Test.dat", FileMode.Create, FileAccess.ReadWrite);

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write((decimal)2.5);

            bw.Write((String)"Vijay");

            bw.Write((int)786);

            Console.WriteLine("Data is successfully written");

            fs.Close();
        }
    }
}
