using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Net.OOP
{
    internal class Employee : Person
    {
        private string designation;
        public String getdesignation()
        {
            return designation;
        }
        public Employee()
        {
            Console.WriteLine("Employee Default Constructor");
        }
        public Employee(String fn, String ln, String des)
        {
            String designaiton = des;
            Console.WriteLine(" Employee 3 param const ");
        }

        public Employee(string fn, string ln) : base(fn, ln)
        {
        }
        public void changeAddress()
        {
            Console.WriteLine("*****");
            base.changeAddress();
            Console.WriteLine("Employee change Address");
        }
        public int getAmount()
        {
            int i = base.getAmount() + 10;
            return i;
        }
    }
}