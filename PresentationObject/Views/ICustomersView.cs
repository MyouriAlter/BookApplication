using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models;

namespace WinForms.Views
{
    /// respresents view of a list of members
    public interface ICustomersView : IView
    {
        IList<CustomerModel> Customers { set; }
    }
}
