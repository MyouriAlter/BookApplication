using DataObjects.AdoNet;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.AdoNet
{
    class CustomerDAO : ICustomerDAO
    {
        static Db db = new Db();
        public bool AddCustomer(Customers customer)
        {
            string sql = "spAddNewCustomer";
            try
            {
                return customer.CustomerPhoneNo == db.Insert(sql, Take(customer)).ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteCustomer(string PhoneNo)
        {
            string sql = "spDeleteCustomer";
            return db.Delete(sql, TakeID(PhoneNo)) > 0;
        }

        public Customers GetCustomer(string PhoneNo)
        {
            string sql = "spGetCustomerByPhone";            
            object[] parms = { "@PhoneNo", PhoneNo };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Customers> GetCustomers()
        {
            string sql = "spGetAllCustomers";            
            return db.Read(sql, Make).ToList();
        }

        public bool UpdateCustomer(Customers customer)
        {
            string sql = "spUpdateCustomer";
            return db.Update(sql, Take(customer)) > 0;
        }

        object[] Take(Customers customer)
        {
            return new object[]
            {
                "@PhoneNo", customer.CustomerPhoneNo,
                "@CustomerName", customer.CustomerName,
                "@Address", customer.Address,
                "@Email", customer.Email,
            };
        }

        object[] TakeID(string PhoneNo)
        {
            return new object[]
            {
                "@PhoneNo", PhoneNo
            };
        }

        // creates a Customer object based on DataReader
        static Func<IDataReader, Customers> Make = reader =>
        new Customers
        {
            CustomerPhoneNo = reader["PhoneNo"].AsString(),
            CustomerName = reader["CustomerName"].AsString(),
            Address = reader["Address"].AsString(),
            Email = reader["Email"].AsString()
        };
    }
}
