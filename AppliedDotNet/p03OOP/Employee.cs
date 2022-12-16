using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{

    /* Class Employee extends Class Person
     * @Author SunilOS
     */
    public class Employee : Person
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
        public void ChangeAddress()
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