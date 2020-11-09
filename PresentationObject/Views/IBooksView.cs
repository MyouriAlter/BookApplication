using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Models;

namespace WinForms.Views
{
    /// respresents view of a list of books
    public interface IBooksView : IView
    {
        IList<BookModel> Books { set; }
    }
}
