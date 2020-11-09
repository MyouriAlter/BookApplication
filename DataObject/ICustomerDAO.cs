using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObject
{
    public interface ICustomerDAO
    {
        //Get a single customer by phone no
        Customers GetCustomer(string PhoneNo);

        //Get all customers
        List<Customers> GetCustomers();

        //Add new customer
        bool AddCustomer(Customers customer);

        //Update a customer
        bool UpdateCustomer(Customers customer);

        //Delete a customer
        bool DeleteCustomer(string PhoneNo);
    }
}
