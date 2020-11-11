using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models;
using WinForms.Views;
using WinForms.Models.Models;

namespace WinForms.Presenters
{
    public class OrderDetailPresenter : Presenter<IOrderDetailView>
    {
        public OrderDetailPresenter(IOrderDetailView view) 
            : base(view)
        {            
        }

        public void ConfirmOrderDetail(string OrderID)
        {
            var orderDetail = new OrderDetailModel
            {
                OrderDetailID = 0,
                Orders = new OrderModel
                {
                    OrderID = OrderID
                },
                BookID = View.DetailBookID,
                //BookTitle = View.DetailBookTitle,
                Quantity = View.DetailQuantity,
                
            };
            Model.AddOrderDetails(orderDetail);

        }
    }
}
