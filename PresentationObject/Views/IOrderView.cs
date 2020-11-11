using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinForms.Views
{
    public interface IOrderView : IView
    {
        string OrderID { get; set; }
        string PhoneNo { get; set; }
        DateTime DateOfReceipt { get; set; }
        //public DateTime ShippedDate { get; set; }
        double TotalPrice { get; set; }
        //public bool Completed { get; set; }
    }
}
