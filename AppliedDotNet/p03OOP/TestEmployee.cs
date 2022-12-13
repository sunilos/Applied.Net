using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class TestEmployee
    {
        public static void Emp()
        {
            Employee e = new Employee("Shubham", "Kumawat", "Corporate Trainer");
            Employee e1 = new Employee("Shubham", "Kumawat");
            Employee e2 = new Employee();

            e2.ChangeAddress();

            String s = e.getfirstName();
            String s1 = e.getlastName();
            String s2 = e.getaddress();
            String s3 = e.getdesignation();
            String s4 = e1.getfirstName();
            String s5 = e1.getlastName();
            String s6 = e2.getaddress();

            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);


            Employee E = new Employee();
            Person p = new Person();
            Person pe = new Employee();
            Console.WriteLine(E.getAmount());
            Console.WriteLine(p.getAmount());
            Console.WriteLine(pe.getAmount());

        }
    }
}