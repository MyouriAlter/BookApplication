using BusinessObjects.BusinessRules;
using DataObjects.AdoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataObject.AdoNet
{
    public class OrdersDAO : IOrdersDAO
    {
        static Db db = new Db();
        public bool AddNewOrder(Orders orders)
        {
            string sql = "spAddNewOrder";
            return orders.OrderID == db.Insert(sql, Take(orders)).ToString();
        }

        public bool DeleteOrder(string OrderID)
        {
            string sql = "spDeleteOrder";
            return db.Delete(sql, TakeID(OrderID)) > 0;
        }

        public string GenerateOrderID()
        {
            string sql = "spGenerateOrderID";
            return db.Read(sql, MakeOrderID, null).FirstOrDefault();
        }

        public Orders GetOrder(string OrderID)
        {
            string sql = "spGetOrderById";
            object[] parms = { "@OrderID", OrderID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Orders> GetOrders()
        {
            string sql = "spGetAllOrder";
            return db.Read(sql, Make).ToList();
        }

        public List<Orders> GetOrdersByCustomer(string phoneNo)
        {
            string sql = "spGetOrderByPhone";
            object[] parms = { "@PhoneNo", phoneNo};
            return db.Read(sql, Make, parms).ToList();
        }

        public bool UpdateOrder(Orders orders)
        {
            string sql = "spUpdateOrder";
            return db.Update(sql, Take(orders)) > 0;
        }

        // creates a Order object based on DataReader
        static Func<IDataReader, Orders> Make = reader =>
        new Orders
        {
            OrderID = reader["OrderID"].AsString(),
            DateOfReceipt = reader["DateOfReceipt"].AsDateTime(),
            TotalPrice = reader["TotalPrice"].AsDouble(),
        };

        static Func<IDataReader, string> MakeOrderID = reader =>
        reader["OrderID"].AsString().ToUpper();


        // creates query parameters list from Order object

        object[] Take(Orders order)
        {
            
            return new object[]
            {
                "@OrderID", order.OrderID,
                "@PhoneNo", order.Customers.CustomerPhoneNo,
                "@DateOfReceipt", order.DateOfReceipt,
                "@TotalPrice", order.TotalPrice
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
