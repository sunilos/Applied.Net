using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
    internal class TestShape1
    {
        public static void Test()
        {
         Shape1 s; //Declaration
         s = new Shape1(); //Instantiation
         s.setColor("Red");
         s.setBorderWidth(3);

            int borderW = s.getBorderWidth();
            String str = s.getColor();

            Console.WriteLine(borderW);
            Console.WriteLine(str);
     }
    }
}
