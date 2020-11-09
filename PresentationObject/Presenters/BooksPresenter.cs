using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForms.Views;


namespace WinForms.Presenters
{
    /// <summary>
    /// Books Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class BooksPresenter : Presenter<IBooksView>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view.</param>
        public BooksPresenter(IBooksView view)
            : base(view)
        {
        }

        /// <summary>
        /// Displays a list of books that are retrieved from model.
        /// </summary>
        public void Display()
        {
            View.Books = Model.GetBooks();
        }

        public void DisplaySearch(string BookTitle)
        {
            View.Books = Model.GetBooksByTitle(BookTitle);
        }
    }
}
