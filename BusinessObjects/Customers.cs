using BusinessObjects.BusinessRules;
using System.Collections.Generic;

namespace BusinessObjects
{
    public class Customers : BusinessObject
    {
        public Customers()
        {
            AddRule(new ValidateRequired("CustomerPhoneNo"));
            AddRule(new ValidatePhone("CustomerPhoneNo"));
            AddRule(new ValidateLength("CustomerPhoneNo", 10, 20));

            AddRule(new ValidateRequired("CustomerName"));
            AddRule(new ValidateLength("CustomerName", 1, 50));

            AddRule(new ValidateRequired("Address"));
            AddRule(new ValidateLength("Address", 1, 50));

            AddRule(new ValidateEmail("Email"));
            AddRule(new ValidateRequired("Email"));

        }
        public string CustomerPhoneNo { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //public List<Orders> Orders { get; set; }

    }
}
