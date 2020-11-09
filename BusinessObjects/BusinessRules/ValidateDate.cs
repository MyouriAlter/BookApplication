using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class ValidateDate : ValidateRegex
    {
        public ValidateDate(string propertyName) 
            : base(propertyName, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$")
        {
            ErrorMessage = propertyName + " is not a valid date! dd/MM/yyyy";
        }

        public ValidateDate(string propertyName, string errorMessage) 
            : this(propertyName)
        {
            ErrorMessage = errorMessage;
        }
    }
}
