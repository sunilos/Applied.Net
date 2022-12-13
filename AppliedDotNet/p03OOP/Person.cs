using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p03OOP
{
    public class Person
    {
        protected String firstName = null;
        protected String lastName = null;
        protected String address = null;

        public int getAmount()
        {
            return 5;
        }
        public String getfirstName()
        {
            return firstName;
        }
        public String getlastName()
        {
            return lastName;
        }
        public String getaddress()
        {
            return address;
        }
        public Person()
        {
            Console.WriteLine("Person Default Con");
        }
        public Person(String fn, String ln)
        {
            firstName = fn;
            lastName = ln;
            Console.WriteLine("2 param wala const bulaya gaya");
        }
        public Person(String fn, String ln, String address) : this(fn, ln)
        {
            firstName = fn;
            lastName = ln;
            this.address = address;
            Console.WriteLine("abhi hum 3 param wale const me he");
        }
        public void changeAddress()
        {
            Console.WriteLine("Person change Address");
        }
    }
}