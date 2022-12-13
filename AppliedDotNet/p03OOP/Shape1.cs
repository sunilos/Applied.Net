using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class Shape1
    {
        private String color = null;
        private int borderWidth = 0;

        public int getBorderWidth()
        {
            return borderWidth;
        }
        public void setBorderWidth(int bw)
        {
            borderWidth = bw;
        }
        public String getColor()
        {
            return color;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
    }
}