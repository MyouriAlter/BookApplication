using DataObjects.AdoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObject.AdoNet
{
    class AccountsDAO : IAccountsDAO
    {
        static Db db = new Db();

        public Accounts GetAccount(string Username, string Password)
        {
            string sql = "spLogin";
            object[] parms = { "@Username", Username, "@Password", Password };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }


        // creates a Accounts object based on DataReader
        static Func<IDataReader, Accounts> Make = reader =>
        new Accounts
        {
            Username = reader["Username"].AsString(),
            Role = reader["Role"].AsBool()
        };
    }
}
