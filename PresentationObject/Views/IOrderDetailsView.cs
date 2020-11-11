using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models.Models;

namespace WinForms.Views
{
    public interface IOrderDetailsView : IView
    {
        IList<OrderDetailModel> OrderDetails { get; set; }
    }
}
