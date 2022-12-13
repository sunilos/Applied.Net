﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class Polymorphism
    {
        public static void Test()
        {
            Shape[] s = new Shape[3];
            s[0] = new Rectangle(10, 20);
            s[1] = new Circle(30);
            s[2] = new Triangle(12, 9);

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i].area() + " ");
            }
        }
    }
}