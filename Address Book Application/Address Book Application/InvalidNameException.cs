using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Application
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message)
            : base(message)
        {
        }
    }
}
