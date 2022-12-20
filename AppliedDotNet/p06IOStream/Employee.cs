using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p06IOStream
{
    /** 
     * This program is serializable class
     * @Author SunilOS
     */
    [Serializable]
    public class Employee
    {
        private int id;
        private String firstName;
        private String lastName;
        [NonSerialized] private String tempValue;

        public Employee(int id, String firstName, String lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int getID()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String getTempValue()
        {
            return tempValue;
        }
        public void setTempValue(String tempValue)
        {
            this.tempValue = tempValue;
        }
    }
}