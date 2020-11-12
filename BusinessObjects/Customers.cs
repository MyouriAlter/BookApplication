using BusinessObjects.BusinessRules;
using System.Collections.Generic;

namespace BusinessObjects
{
    public class Customers
    {
        public Customers()
        {

        }
        public string CustomerPhoneNo { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //public List<Orders> Orders { get; set; }

    }
}
