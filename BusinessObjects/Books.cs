using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public class Books
    {
        public Books()
        {
        }

        public int BookID { get; set; }
        public string BookTitle { get; set; }        
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
