using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using ActionService;
using AutoMapper;
using BusinessObjects.BusinessRules;
using WinForms.Models.Models;

namespace WinForms.Models
{
    public class Model : IModel
    {
        static Service service = new Service();

        static Model()
        {
            Mapper.CreateMap<Customers, CustomerModel>();
            Mapper.CreateMap<CustomerModel, Customers>();
            Mapper.CreateMap<Orders, OrderModel>();
            Mapper.CreateMap<OrderModel, Orders>();
            Mapper.CreateMap<OrderDetails, OrderDetailModel>();
            Mapper.CreateMap<OrderDetailModel, OrderDetails>();
            Mapper.CreateMap<Books, BookModel>();
            Mapper.CreateMap<BookModel, Books>();
        }

        #region Login / Logout

        // Logs in to the service.
        public bool Login(string username, string password)
        {
            // beneath Service runs WebService which unfortunately was not really designed for Windows apps. 
            // one solution would be to use a webservice

            return service.GetAccount(username, password) != null;
            //return true;

        }

        // Logs out of the service.
        public void Logout()
        {
            // beneath Service runs WebService which unfortunately was not really designed for Windows apps. 
            // one solution would be to use a webservice

            // service.Logout();
        }

        #endregion

        #region Customers

        // gets a complete list of Customers and their orders and order details.

        public List<CustomerModel> GetCustomers()
        {
            var customers = service.GetCustomers();
            return Mapper.Map<List<Customers>, List<CustomerModel>>(customers);
        }

        // gets a specific Customer.
        public CustomerModel GetCustomer(string phoneNo)
        {
            var customer = service.GetCustomer(phoneNo);
            return Mapper.Map<Customers, CustomerModel>(customer);
        }

        #endregion

        #region Customer persistence

        // adds a new Customer to the database.
        public void AddCustomers(CustomerModel model)
        {
            var customer = Mapper.Map<CustomerModel, Customers>(model);
            try
            {
                service.AddCustomer(customer);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // updates an existing Customer in the database.
        public void UpdateCustomers(CustomerModel model)
        {
            var customer = Mapper.Map<CustomerModel, Customers>(model);
            service.UpdateCustomer(customer);
        }

        // deletes a Customer record.
        public void DeleteCustomers(string phoneNo)
        {
            var customer = service.GetCustomer(phoneNo);
            service.DeleteCustomer(phoneNo);
        }

        #endregion

        #region Books

        public List<BookModel> GetBooks()
        {
            var books = service.GetBooks();
            return Mapper.Map<List<Books>, List<BookModel>>(books);
        }

        public BookModel GetBook(int bookID)
        {
            var book = service.GetBook(bookID);
            return Mapper.Map<Books, BookModel>(book);
        }

        public List<BookModel> GetBooksByTitle(string BookTitle)
        {
            var books = service.GetBooksByTitle(BookTitle);
            return Mapper.Map<List<Books>, List<BookModel>>(books);
        }

        #endregion

        #region Book presistence

        public void AddBooks(BookModel model)
        {
            var book = Mapper.Map<BookModel, Books>(model);
            service.AddNewBook(book);
        }

        public void UpdateBooks(BookModel model)
        {
            var book = Mapper.Map<BookModel, Books>(model);
            service.UpdateBook(book);
        }

        public void DeleteBooks(int bookID)
        {
            var book = service.GetBook(bookID);
            service.DeleteBook(bookID);
        }

        public void UpdateBookQuantity(int BookID, int Quantity)
        {
            service.UpdateBookQuantity(BookID, Quantity);
        }

        #endregion

        #region Orders

        // gets a list of orders for a given Customer.

        public List<OrderModel> GetOrders(string phoneNo)
        {
            var orders = service.GetOrdersByCustomer(phoneNo);
            var models = Mapper.Map<List<Orders>, List<OrderModel>>(orders);
                        
            var books = service.GetBooks();
            // rather inefficient. the service API is not flexible enough to perform larger batch retrieves.
            // see Spark for a richer API with generic Repositories
            foreach (var model in models)
            {
                var details = service.GetOrderDetails(model.OrderID);
                //details.ForEach(d => d.BookTitle = books[d.BookID].BookTitle);
                model.OrderDetails = Mapper.Map<List<OrderDetails>, List<OrderDetailModel>>(details);
            }

            return models;
        }

        #endregion

        #region Order persistence

        public void AddOrders(OrderModel model)
        {
            var order = Mapper.Map<OrderModel, Orders>(model);
            service.AddNewOrder(order);
        }

        public void UpdateOrders(OrderModel model)
        {
            var order = Mapper.Map<OrderModel, Orders>(model);
            service.UpdateOrder(order);
        }

        public void DeleteOrders(string orderID)
        {
            var order = service.GetOrder(orderID);
            service.DeleteOrder(orderID);
        }
        public string GenerateOrderID()
        {
            return service.GenerateOrderID();
        }


        #endregion

        #region Order Detail persistence

        public void AddOrderDetails(OrderDetailModel model)
        {
            var orderDetail = Mapper.Map<OrderDetailModel, OrderDetails>(model);
            service.AddOrderDetail(orderDetail);
        }

        public void DeleteAllOrderDetails(string OrderID)
        {
            service.DeleteAllOrderDetails(OrderID);
        }

        public List<OrderDetailModel> GetOrderDetails(string OrderID)
        {
            var orderDetails = service.GetOrderDetails(OrderID);
            return Mapper.Map<List<OrderDetails>, List<OrderDetailModel>>(orderDetails);
        }


        #endregion

    }
}
