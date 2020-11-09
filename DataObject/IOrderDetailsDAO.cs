using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObject
{
    public interface IOrderDetailsDAO
    {
        //Get all orderdetails by order id
        List<OrderDetails> GetOrderDetails(string OrderID);

        //Delete all orderdetails by order id
        bool DeleteOrderDetails(string OrderID);

        //Add new orderdetail
        bool AddOrderDetail(OrderDetails orderDetails);
    }
}
