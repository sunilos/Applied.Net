using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    /* Custom checked exception class. It is checked because it inherits ApplicationException.
     * @Author SunilOS
     */
    public class LoginException : ApplicationException
    {
        public LoginException(string msg) : base(msg)
        {

        }
    }
}