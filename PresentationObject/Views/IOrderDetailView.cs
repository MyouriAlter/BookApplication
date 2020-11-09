using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;

namespace WinFroms.Views
{
    public interface IOrderDetailView : IView
    {
        int OrderDetailID { get; set; }
        string DetailOrderID { get; set; }
        string DetailBookTitle { get; set; }
        int DetailBookId { get; set; }
        int DetailQuantity { get; set; }
    }
}
