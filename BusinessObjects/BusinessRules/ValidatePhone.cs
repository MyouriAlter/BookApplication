using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class ValidatePhone : ValidateRegex
    {
        public ValidatePhone(string propertyName) 
            : base(propertyName, @"[^0-9]")
        {
            ErrorMessage = propertyName + " is not a valid phone number.";
        }

        public ValidatePhone(string propertyName, string errorMessage) 
            : this(propertyName)
        {
            ErrorMessage = errorMessage;
        }
    }
}
