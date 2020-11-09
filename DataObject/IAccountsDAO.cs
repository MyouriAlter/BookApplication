using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObject
{
    public interface IAccountsDAO
    {
        //Check login and get role
        Accounts GetAccount(string Username, string Password);
    }
}
