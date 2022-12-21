using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**
     * Serialize an object and write to a file.
     * @Author SunilOS
     */
    public class SerializeObjectWrite
    {
        public static void Test()
        {
            Employee emp = new Employee(1, "Sun", "Rays");

            FileStream stream = new FileStream("C:/emp.obj", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, emp);

            stream.Close();

            Console.WriteLine("Done");
        }
    }
}
