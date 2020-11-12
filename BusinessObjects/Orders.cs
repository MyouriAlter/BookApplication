using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.BusinessRules
{
    public class Orders
    {
        public Orders()
        {
        }
        public string OrderID { get; set; }  
        public DateTime DateOfReceipt { get; set; }
        public double TotalPrice { get; set; }

        public Customers Customers { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

    }
}
