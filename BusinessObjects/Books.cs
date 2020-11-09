using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public class Books : BusinessObject
    {
        public Books()
        {
            AddRule(new ValidateId("BookID"));
            AddRule(new ValidateRequired("BookID"));

            AddRule(new ValidateRequired("BookTitle"));
            AddRule(new ValidateLength("BookTitle", 1, 100));

            AddRule(new ValidateRequired("Address"));
            AddRule(new ValidateLength("Address", 1, 100));


            AddRule(new ValidateRequired("Publisher"));
            AddRule(new ValidateLength("Publisher", 1, 100));


            AddRule(new ValidateRequired("PublishDate"));
            AddRule(new ValidateDate("PublishDate"));

            AddRule(new ValidateRequired("Price"));
            AddRule(new ValidatePrice("Price"));
            AddRule(new ValidateLength("Price", 1, 100));
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
