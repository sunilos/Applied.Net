using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p01basics
{
    /**
     * Program to check the string methods
     * @Author SunilOS   
     */
    public class StringMethods
    {
        public static void Test()
        {
            String name = "Vijay Dinanth Chouhan";
            String surname = "Vijay Dinanth Chouhan";

            Console.WriteLine((string.Equals(name, surname))) ;
            Console.WriteLine(" String Length- " + name.Length);
            Console.WriteLine(" 7 ths caharcter is- " + name[6]);
            Console.WriteLine(" Dina index is- " + name.IndexOf("Dina"));
            Console.WriteLine(" First i Position- " + name.IndexOf("i"));
            Console.WriteLine(" Last i Position- " + name.LastIndexOf("i"));
            Console.WriteLine(" a is replaced by b- " + name.Replace("a", "b"));
            Console.WriteLine(" Chota vijay- " + name.ToLower());
            Console.WriteLine(" Bada vijay- " + name.ToUpper());
            Console.WriteLine(" Starts With Vijay- " + name.StartsWith("Vijay"));
            Console.WriteLine(" Ends with han- " + name.EndsWith("han"));
            Console.WriteLine(" Substring- " + name.Substring(6));
        }
    }
}