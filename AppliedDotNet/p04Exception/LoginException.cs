using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedDotNet.p04Exception
{
    public class LoginException : ApplicationException
    {
        public LoginException(string msg) : base(msg)
        {

        }
    }
}