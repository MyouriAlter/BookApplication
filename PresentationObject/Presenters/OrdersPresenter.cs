using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WinForms.Views;


namespace WinForms.Presenters
{
    /// <summary>
    /// Orders Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class OrdersPresenter : Presenter<IOrdersView>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view</param>
        public OrdersPresenter(IOrdersView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays list of orders.
        /// </summary>
        /// <param name="PhoneNo">Customer phone number to display.</param>
        public void Display(string PhoneNo)
        {
            View.Orders = Model.GetOrders(PhoneNo);
        }       

    }
}
