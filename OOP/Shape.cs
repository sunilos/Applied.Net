using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
      public class Shape
      {
        const float PI = 3.14f;
        private String color = null;
        private int borderWidth = 0;

        public Shape()
        {
            System.Console.WriteLine("This is default constuctor");
        }
        public Shape(String c, int w)
        {
            this.color = c;
            this.borderWidth = w;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
        public String getColor()
            {
            return color;
            }
        public void setBorderWidth(int bw)
        {
            borderWidth = bw;
        }
        public int getBorderWidth()
            {
            return borderWidth;
            }
        public virtual float area()
        {
            return 0;
        }

      }

}