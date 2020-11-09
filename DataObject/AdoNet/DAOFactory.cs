using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.AdoNet
{
    // Data access object factory
    // ** Factory Pattern

    public class DAOFactory : IDAOFactory
    {
        public IAccountsDAO AccountsDAO { get { return new AccountsDAO(); } }

        public IOrdersDAO OrdersDAO { get { return new OrdersDAO(); } }

        public IBooksDAO BooksDAO { get { return new BooksDAO(); } }

        public ICustomerDAO CustomerDAO { get { return new CustomerDAO(); } }

        public IOrderDetailsDAO OrderDetailDAO { get { return new OrderDetailsDAO(); } }
    }
}
