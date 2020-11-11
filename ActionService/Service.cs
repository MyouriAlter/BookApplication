using DataObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using BusinessObjects.BusinessRules;

namespace ActionService
{
    public class Service : IService
    {
        static readonly IDAOFactory factory = DAOFactory.GetFactory();
        static readonly IAccountsDAO accountsDAO = factory.AccountsDAO;
        static readonly IBooksDAO booksDAO = factory.BooksDAO;
        static readonly ICustomerDAO customerDAO = factory.CustomerDAO;
        static readonly IOrdersDAO ordersDAO = factory.OrdersDAO;
        static readonly IOrderDetailsDAO orderDetailsDAO = factory.OrderDetailDAO;

        public bool AddCustomer(Customers customer)
        {
            try
            {
                return customerDAO.AddCustomer(customer);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool AddNewBook(Books book)
        {
            return booksDAO.AddNewBook(book);
        }

        public bool AddNewOrder(Orders orders)
        {
            return ordersDAO.AddNewOrder(orders);
        }

        public bool AddOrderDetail(OrderDetails orderDetails)
        {
            return orderDetailsDAO.AddOrderDetail(orderDetails);
        }

        public bool DeleteBook(int BookID)
        {
            return booksDAO.DeleteBook(BookID);
        }

        public bool DeleteCustomer(string PhoneNo)
        {
            return customerDAO.DeleteCustomer(PhoneNo);
        }

        public bool DeleteOrder(string OrderID)
        {
            return ordersDAO.DeleteOrder(OrderID);
        }

        public bool DeleteAllOrderDetails(string OrderID)
        {
            return orderDetailsDAO.DeleteOrderDetails(OrderID);
        }

        public string GenerateOrderID()
        {
            return ordersDAO.GenerateOrderID();
        }

        public Accounts GetAccount(string Username, string Password)
        {
            return accountsDAO.GetAccount(Username, Password);
        }

        public Books GetBook(int BookID)
        {
            return booksDAO.GetBook(BookID);
        }

        public List<Books> GetBooks()
        {
            return booksDAO.GetBooks();
        }

        public Customers GetCustomer(string PhoneNo)
        {
            return customerDAO.GetCustomer(PhoneNo);
        }

        public List<Customers> GetCustomers()
        {
            return customerDAO.GetCustomers();
        }

        public Orders GetOrder(string OrderID)
        {
            return ordersDAO.GetOrder(OrderID);
        }

        public List<OrderDetails> GetOrderDetails(string OrderID)
        {
            return orderDetailsDAO.GetOrderDetails(OrderID);
        }

        public List<Orders> GetOrders()
        {
            return ordersDAO.GetOrders();
        }

        public List<Orders> GetOrdersByCustomer(string phoneNo)
        {
            return ordersDAO.GetOrdersByCustomer(phoneNo);
        }

        public bool UpdateBook(Books book)
        {
            return booksDAO.UpdateBook(book);
        }

        public bool UpdateBookQuantity(int BookID, int Quantity)
        {
            return booksDAO.UpdateBookQuantity(BookID, Quantity);
        }

        public bool UpdateCustomer(Customers customer)
        {
            return customerDAO.UpdateCustomer(customer);
        }

        public bool UpdateOrder(Orders orders)
        {
            return ordersDAO.UpdateOrder(orders);
        }

        public List<Books> GetBooksByTitle(string BookTitle)
        {
            return booksDAO.GetBooksByTitle(BookTitle);
        }

        
    }
}
