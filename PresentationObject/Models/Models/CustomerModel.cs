using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            Orders = new List<OrderModel>();
        }
        public string CustomerPhoneNo { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public IList<OrderModel> Orders { get; set; }
    }
}
