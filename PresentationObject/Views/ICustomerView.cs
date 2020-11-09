using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    // represents a single customer view

    public interface ICustomerView : IView
    {
        string CustomerPhoneNo { get; set; }
        string CustomerName { get; set; }
        string Email { get; set; }
        string Address { get;set; }
    }
}
