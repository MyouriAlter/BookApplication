using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models.Models;

namespace WinForms.Models
{
    // IModel interface, part of MVP design pattern.

    public interface IModel
    {
        bool Login(string username, string password);
        void Logout();

        List<BookModel> GetBooks();
        List<BookModel> GetBooksByTitle(string BookTitle);
        BookModel GetBook(int bookID);

        List<CustomerModel> GetCustomers();
        CustomerModel GetCustomer(string PhoneNo);

        void AddBooks(BookModel book);
        void UpdateBooks(BookModel book);
        void DeleteBooks(int bookID);
        void UpdateBookQuantity(int BookID, int Quantity);

        void AddCustomers(CustomerModel customer);
        void UpdateCustomers(CustomerModel customer);
        void DeleteCustomers(string PhoneNo);

        void AddOrders(OrderModel order);
        void UpdateOrders(OrderModel order);
        void DeleteOrders(string orderID);

        void AddOrderDetails(OrderDetailModel orderDetail);
        void DeleteAllOrderDetails(string OrderID);
        string GenerateOrderID();

        List<OrderDetailModel> GetOrderDetails(string OrderID);

        List<OrderModel> GetOrders(string PhoneNo);
    }
}
