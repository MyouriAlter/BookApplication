using DataObjects.AdoNet;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace DataObject.AdoNet
{
    class OrderDetailsDAO : IOrderDetailsDAO
    {
        static Db db = new Db();

        public bool AddOrderDetail(OrderDetails orderDetails)
        {
            string sql = "spAddNewOrderDetail";
            return orderDetails.OrderDetailID == db.Insert(sql, Take(orderDetails));
        }

        public bool DeleteOrderDetails(string OrderID)
        {
            string sql = "spDeleteAllOrderDetails";
            return db.Delete(sql, TakeID(OrderID)) > 0;
        }

        public List<OrderDetails> GetOrderDetails(string OrderID)
        {
            string sql = "spGetAllOrderDetails";
            object[] parms = { "@OrderID", OrderID };
            return db.Read(sql, Make, parms).ToList();
        }


        static Func<IDataReader, OrderDetails> Make = reader =>
            new OrderDetails
            {            
                OrderDetailID = reader["OrderDetailID"].AsInt(),
                OrderID = reader["OrderID"].AsString(),
                BookID = reader["BookID"].AsInt(),
                BookTitle = reader["BookTitle"].AsString(),
                Quantity = reader["Quantity"].AsInt()
            };

        object[] Take(OrderDetails orderDetails)
        {
            return new object[]
            {
                "@OrderDetailID", orderDetails.OrderDetailID,
                "@OrderID", orderDetails.Orders.OrderID,
                "@BookID", orderDetails.BookID,
                //"@BookTitle", orderDetails.BookTitle,
                "@Quantity", orderDetails.Quantity
            };
        }

        object[] TakeID(string OrderID)
        {
            return new object[]
            {
                "@OrderID", OrderID
            };
        }
    }
}
