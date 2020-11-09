using BusinessObjects.BusinessRules;

namespace BusinessObjects
{

    // Order Detail business object
    // ** Enterprise Design Pattern: Domain Model, Identity Field, Foreign key mapping


    public class OrderDetails : BusinessObject
    {

        // ** Enterprise Design Pattern: Identity field pattern

        public int OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int Quantity { get; set; }    
        

        // ** Enterprise Design Pattern: Foreign Key Mapping. Order is the parent

        public Orders Orders { get; set; }
    }
}
