using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObject
{
    public interface IBooksDAO
    {
        //Get a single book by ID
        Books GetBook(int BookID);

        //Get all books
        List<Books> GetBooks();

        //Add new book
        bool AddNewBook(Books book);

        //Update a book
        bool UpdateBook(Books book);

        //Delete a book
        bool DeleteBook(int BookID);

        //Get books by title
        List<Books> GetBooksByTitle(string BookTitle);

        bool UpdateBookQuantity(int BookID, int Quantity);
    }
}
