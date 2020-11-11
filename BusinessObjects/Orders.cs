using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class Orders : BusinessObject
    {
        public Orders()
        {
            AddRule(new ValidateRequired("OrderID"));
            AddRule(new ValidateId("OrderID"));

            AddRule(new ValidateRequired("PhoneNo"));
            AddRule(new ValidatePhone("PhoneNo"));

            AddRule(new ValidateRequired("DateOfReceipt"));
            AddRule(new ValidateDate("DateOfReceipt"));

            AddRule(new ValidateRequired("TotalPrice"));
            AddRule(new ValidatePrice("TotalPrice"));
            AddRule(new ValidateLength("TotalPrice", 1, 100));


        }
        public string OrderID { get; set; }  
        public DateTime DateOfReceipt { get; set; }
        public double TotalPrice { get; set; }

        public Customers Customers { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

    }
}
