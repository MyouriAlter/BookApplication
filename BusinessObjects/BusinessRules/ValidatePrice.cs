using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class ValidatePrice : ValidateRegex
    {
        public ValidatePrice(string propertyName)
            : base(propertyName, @"[^0-9]")
        {
            ErrorMessage = propertyName + " is not a valid price.";
        }

        public ValidatePrice(string propertyName, string errorMessage)
            : this(propertyName)
        {
            ErrorMessage = errorMessage;
        }

    }
}
