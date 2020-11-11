using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using WinForms.Models;
using WinForms.Presenters;
using WinForms.Views;

namespace WinForms.Presenters
{
    /// <summary>
    /// Customer Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class CustomerPresenter : Presenter<ICustomerView>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view</param>
        public CustomerPresenter(ICustomerView view)
            : base(view)
        {
        }

        /// <summary>
        /// Gets customer from model and sets values in the view.
        /// </summary>
        /// <param name="memberId">Book to display</param>
        public void Display(string PhoneNo)
        {
            if (PhoneNo == string.Empty) return;

            var customer = Model.GetCustomer(PhoneNo);

            View.CustomerPhoneNo = customer.CustomerPhoneNo;
            View.CustomerName = customer.CustomerName;
            View.Email = customer.Email;
            View.Address = customer.Address;
        }

        /// <summary>
        /// Saves a customer by getting view data and sending it to model.
        /// </summary>
        /// <returns>Number of records affected.</returns>
        public void Save(bool action)
        {
            
            var customer = new CustomerModel
            {
                CustomerPhoneNo = View.CustomerPhoneNo,
                CustomerName = View.CustomerName,
                Email = View.Email,
                Address = View.Address
            };

            if (action == true)
            {
                Model.AddCustomers(customer);
            }
            else
            {
                Model.UpdateCustomers(customer);
            }
        }

        /// <summary>
        /// Deletes a customer by calling into model.
        /// </summary>
        /// <param name="phoneNo">The customer to delete</param>
        /// <returns>Number of records affected.</returns>
        public void Delete(string phoneNo)
        {
            Model.DeleteCustomers(phoneNo);
        }
    }
}