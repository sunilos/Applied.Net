using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
    internal class Encapsulation
    {
            String color = null;
            int borderWidth = 0;
            const float PI = 3.14f;
            
        public int getBorderWidth()
            {
                return borderWidth;
            }
         
        public void setBorderWidth(int borderWidth)
            {
                this.borderWidth = borderWidth;
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