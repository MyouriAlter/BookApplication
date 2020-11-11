using DataObjects.AdoNet;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.AdoNet
{
    class BooksDAO : IBooksDAO
    {
        static Db db = new Db();

        public bool AddNewBook(Books book)
        {
            string sql = "spAddNewBook";
            return (book.BookID = db.Insert(sql, Take(book))) > 0;
        }

        public bool DeleteBook(int BookID)
        {
            string sql = "spDeleteBook";
            return db.Delete(sql, TakeID(BookID)) > 0;
        }

        public Books GetBook(int BookID)
        {
            string sql = "spGetBookById";
            object[] parms = { "@BookID", BookID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Books> GetBooks()
        {
            string sql = "spGetBooks";
            return db.Read(sql, Make).ToList();
        }

        public bool UpdateBook(Books book)
        {
            string sql = "spUpdateBook";
            return db.Update(sql, Take(book)) > 0;
        }

        public List<Books> GetBooksByTitle(string BookTitle)
        {
            string sql = "spGetBooksByTitle";
            return db.Read(sql, Make, TakeTitle(BookTitle)).ToList();
        }

        public bool UpdateBookQuantity(int BookID, int Quantity)
        {
            string sql = "spUpdateBookQuantity";
            object[] parms = { "@BookID", BookID, "@Quantity", Quantity };
            return db.Update(sql, parms) > 0;
        }

        // creates a Books object based on DataReader
        static Func<IDataReader, Books> Make = reader =>
        new Books
        {
            BookID = reader["BookID"].AsInt(),
            BookTitle = reader["BookTitle"].AsString(),
            Author = reader["Author"].AsString(),
            Publisher = reader["Publisher"].AsString(),
            PublishDate = reader["PublishDate"].AsDateTime(),
            Price = reader["Price"].AsDouble(),
            Quantity = reader["Quantity"].AsInt()
        };

        // creates query parameters list from Books object

        object[] Take(Books book)
        {
            return new object[]
            {
                "@BookID", book.BookID,
                "@BookTitle", book.BookTitle,
                "@Author", book.Author,
                "@Publisher", book.Publisher,
                "@PublishDate", book.PublishDate,
                "@Price", book.Price,
                "@Quantity", book.Quantity
            };
        }

        object[] TakeID(int BookID)
        {
            return new object[]
            {
                "@BookID", BookID
            };
        }

        object[] TakeTitle(string BookTitle)
        {
            return new object[]
            {
                "@BookTitle", BookTitle
            };
        }

        
    }
}
