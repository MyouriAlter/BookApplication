using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using BusinessObjects.BusinessRules;

namespace ActionService
{
    public interface IService
    {
        //Account repo
        Accounts GetAccount(string Username, string Password);

        //Book repo
        Books GetBook(int BookID);
        List<Books> GetBooks();
        List<Books> GetBooksByTitle(string BookTitle);
        bool AddNewBook(Books book);
        bool UpdateBook(Books book);
        bool DeleteBook(int BookID);
        bool UpdateBookQuantity(int BookID, int Quantity);

        //Customer repo
        Customers GetCustomer(string PhoneNo);
        List<Customers> GetCustomers();
        bool AddCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(string PhoneNo);

        #region Order

        Orders GetOrder(string OrderID);
        List<Orders> GetOrders();
        List<Orders> GetOrdersByCustomer(string phoneNo);
        bool AddNewOrder(Orders orders);
        bool UpdateOrder(Orders orders);
        bool DeleteOrder(string OrderID);
        string GenerateOrderID();

        #endregion

        #region OrderDetail
        List<OrderDetails> GetOrderDetails(string OrderID);
        bool DeleteAllOrderDetails(string OrderID);
        bool AddOrderDetail(OrderDetails orderDetails);
        #endregion
    }
}
