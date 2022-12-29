using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**
     * Reads primitive data from a binary stream.
     * @Author SunilOS
     */
    public class ReadPrimitiveData
    {
        public static void Test()
        {
            FileStream fs = new FileStream("C:/test.dat", FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine(br.ReadDecimal());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());

            fs.Close();
        }
    }
}
