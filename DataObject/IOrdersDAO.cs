using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace DataObject
{
    public interface IOrdersDAO
    {
        //Get order by id
        Orders GetOrder(string OrderID);

        //Get all orders
        List<Orders> GetOrders();

        //Get all orders for a customer
        List<Orders> GetOrdersByCustomer(string phoneNo);

        //Add new order
        bool AddNewOrder(Orders orders);

        //Update order
        bool UpdateOrder(Orders orders);

        //Delete order
        bool DeleteOrder(string OrderID);

        //Generate order id
        string GenerateOrderID();
    }
}
