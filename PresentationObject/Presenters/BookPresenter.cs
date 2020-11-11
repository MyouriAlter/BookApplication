using BookSaleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    /// <summary>
    /// Book Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class BookPresenter : Presenter<IBookView>
    {
        public frmMain FrmManager { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view</param>
        public BookPresenter(IBookView view)
            : base(view)
        {
        }

        /// <summary>
        /// Gets book from model and sets values in the view.
        /// </summary>
        /// <param name="memberId">Book to display</param>
        public void Display(int bookID)
        {
            if (bookID <= 0) return;

            var book = Model.GetBook(bookID);

            View.ID = book.BookID;
            View.Title = book.BookTitle;
            View.Author = book.Author;
            View.Publisher = book.Publisher;
            View.PublishDate = book.PublishDate;
            View.Price = book.Price;
            View.Quantity = book.Quantity;
        }

        /// <summary>
        /// Saves a book by getting view data and sending it to model.
        /// </summary>
        /// <returns>Number of records affected.</returns>
        public void Save(bool action)
        {
            var book = new BookModel
            {
                BookID = View.ID,
                BookTitle = View.Title,
                Author = View.Author,
                Publisher = View.Publisher,
                PublishDate = View.PublishDate,
                Price = View.Price,
                Quantity = View.Quantity
            };

            if (action == true) //Add
                Model.AddBooks(book);
            else //Update
                Model.UpdateBooks(book);
        }

        /// <summary>
        /// Deletes a book by calling into model.
        /// </summary>
        /// <param name="bookID">The book to delete</param>
        /// <returns>Number of records affected.</returns>
        public void Delete(int bookID)
        {
            Model.DeleteBooks(bookID);
        }

        public void UpdateBookQuantity(int bookID, int quantity)
        {
            Model.UpdateBookQuantity(bookID, quantity);
        }

    }
}