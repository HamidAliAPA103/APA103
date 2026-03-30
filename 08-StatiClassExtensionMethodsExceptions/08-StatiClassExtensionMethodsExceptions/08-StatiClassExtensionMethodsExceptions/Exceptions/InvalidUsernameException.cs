using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class InvalidUsernameException:Exception 
    {
        public InvalidUsernameException(): base("Username duz deil")
        {
        }
        public InvalidUsernameException(string message) : base(message)
        {         
        }
    }
}
