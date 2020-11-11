using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class OrderPresenter : Presenter<IOrderView>
    {
        public OrderPresenter(IOrderView view) : base(view)
        {
        }

        public void ConfirmOrder()
        {
            var order = new OrderModel()
            {
                OrderID = Model.GenerateOrderID(),
                Customers = new CustomerModel()
                {
                    CustomerPhoneNo = View.PhoneNo
                },
                DateOfReceipt = View.DateOfReceipt,
                TotalPrice = View.TotalPrice
            };
            Model.AddOrders(order);
            View.OrderID = order.OrderID;
        }

        public void DeleteOrder(string orderID)
        {
            Model.DeleteAllOrderDetails(orderID);
            Model.DeleteOrders(orderID);
        }

    }
}
