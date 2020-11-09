using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForms.Views;


namespace WinForms.Presenters
{
    /// <summary>
    /// Customers Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class CustomersPresenter : Presenter<ICustomersView>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view.</param>
        public CustomersPresenter(ICustomersView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays a list of customer that are retrieved from model.
        /// </summary>
        public void Display()
        {
            View.Customers = Model.GetCustomers();
        }
    }
}
