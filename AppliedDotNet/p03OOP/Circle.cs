using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    /* Inherits Shape class and contains attributes of Circle.
     * @Author SunilOS
     */
    public class Circle : Shape
    {
        private int radius = 0;
        static float PI = 3.14f;

        public Circle()
        {

        }
        public Circle(int q)
        {
            this.radius = q;
        }
        public int getradius()
        {
            return radius;
        }
        public void setradius(int r)
        {
            radius = r;
        }
        public override float area()
        {
            return Circle.PI * radius * radius;
        }
    }
}