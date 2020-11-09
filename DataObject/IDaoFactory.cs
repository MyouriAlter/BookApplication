using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    public interface IDAOFactory
    {
        IAccountsDAO AccountsDAO { get; }
        IOrdersDAO OrdersDAO { get; }
        IBooksDAO BooksDAO { get; }
        ICustomerDAO CustomerDAO { get; }
        IOrderDetailsDAO OrderDetailDAO { get; }
    }
}
