using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;


namespace WinForms.Presenters
{
    public class OrderDetailsPresenter : Presenter<IOrderDetailView>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view.</param>
        public OrderDetailsPresenter(IOrderDetailView view) : base(view)
        {
        }

        /*
        public void Display()
        {
            View.OrderDetail = Model.GetOrderDetails();
        }
        */

    }
}
