using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Exceptions
{
    public class ValidationException : Exception
    {
        public string ProperytName {  get; private set; }

        public ValidationException(string message, string propertyName) : base(message + "Date: " + DateTime.Now)
        {
            ProperytName = propertyName;
        }
        public ValidationException(string message) : base(message + " Date: " + DateTime.Now)
        {

        }

        public ValidationException()
        {

        }

    }
}
