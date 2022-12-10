using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
    internal class TestEncapsulation
    {
        public static void test()
        {
            Encapsulation e = new Encapsulation();

            e.setColor("Red");
            e.setBorderWidth(100);

            String s = e.getColor();
            int i = e.getBorderWidth();

            Console.WriteLine(s);
            Console.WriteLine(i);

        }
    }
}
