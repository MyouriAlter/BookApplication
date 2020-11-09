using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    // represents view of single book
    public interface IBookView : IView
    {
        int ID { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        DateTime PublishDate { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
    }
}
