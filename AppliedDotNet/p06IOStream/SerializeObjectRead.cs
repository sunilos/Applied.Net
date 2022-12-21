using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /**
     * Deserialize an object from a File.
     * @Author SunilOS
     */
    public class SerializeObjectRead
    {
        public static void Test()
        {
            FileStream stream = new FileStream("C:/emp.obj", FileMode.Open);
            
            BinaryFormatter bf = new BinaryFormatter();
            
            Employee emp = (Employee)bf.Deserialize(stream);
            
            Console.WriteLine("ID : " + emp.getID());
            Console.WriteLine("F Name : " + emp.getFirstName());
            Console.WriteLine("L Name : " + emp.getLastName());
            Console.WriteLine("Temp Value: " + emp.getTempValue());
        }
    }
}
