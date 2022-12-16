using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    /* Inherits Shape class and contains attributes of Triangle.
     * @Author SunilOS
     */
    public class Triangle : Shape
    {
        private int Base = 0;
        private int height = 0;

        public Triangle()
        {

        }
        public Triangle(int a, int b)
        {
            this.Base = a;
            this.height = b;
        }
        public void setBase(int B)
        {
            this.Base = B;
        }
        public int getBase()
        {
            return Base;
        }
        public void setheight(int h)
        {
            this.height = h;
        }
        public int getheight()
        {
            return height;
        }
        public override float area()
        {
            float v = (float)(0.5 * Base * height);
            return v;
        }
    }
}