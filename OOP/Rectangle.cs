using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
    internal class Rectangle : Shape
    {
        private int length = 0;
        private int width = 0;

        public Rectangle()
        {
           
        }
        public Rectangle(int c, int d)
        {
            this.length = c;
            this.width = d; 
        }
        public void setlength(int l)
        {
            this.length = l;
        }
        public int getlength()
        {
            return length;
        }
        public void setwidth(int w)
        {
            this.width = w;
        }
        public int getwidth()
        {
            return width;
        }
        public override float area()
        {
            return length * width;
        }
    }
}