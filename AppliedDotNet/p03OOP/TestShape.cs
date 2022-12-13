using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class TestShape
    {
        public static void shape()
        {

            /*  Shape s = new Shape("blue", 10);
              String color = s.getColor();
              int borderW = s.getBorderWidth();
              Console.WriteLine(borderW);
              Console.WriteLine(color); */

            Circle c = new Circle();
            c.setColor("Green Circle");
            c.setBorderWidth(10);
            c.setradius(3);

            int a = c.getBorderWidth();
            String x = c.getColor();
            int i = c.getradius();
            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(i);
            Console.WriteLine(c.area());

            Triangle t = new Triangle();
            t.setColor("Blue Traingle");
            t.setBorderWidth(7);
            t.setheight(20);
            t.setBase(19);

            int f = t.getBorderWidth();
            String k = t.getColor();
            int v = t.getheight();
            int e = t.getBase();
            Console.WriteLine(f);
            Console.WriteLine(k);
            Console.WriteLine(v);
            Console.WriteLine(e);
            Console.WriteLine(t.area());

            Rectangle r = new Rectangle();
            r.setColor("Pink Rectangle");
            r.setBorderWidth(8);
            r.setlength(7);
            r.setwidth(9);

            int g = r.getBorderWidth();
            String s = r.getColor();
            int w = r.getlength();
            int q = r.getwidth();
            Console.WriteLine(g);
            Console.WriteLine(s);
            Console.WriteLine(w);
            Console.WriteLine(q);
            Console.WriteLine(r.area());
        }
    }
}