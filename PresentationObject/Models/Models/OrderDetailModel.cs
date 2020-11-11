using WinForms.Models;

namespace WinForms.Models.Models
{
    public class OrderDetailModel
    {
        public int OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public string BookTitle { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public OrderModel Orders { get; set; }
    }
}
