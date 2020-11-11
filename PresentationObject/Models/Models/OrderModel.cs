using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models.Models;

namespace WinForms.Models
{
    public class OrderModel
    {
        public string OrderID { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public double TotalPrice { get; set; }
        //public string PhoneNo { get; set; }
        public IList<OrderDetailModel> OrderDetails { get; set; }
        public CustomerModel Customers { get; set; }
    }
}
