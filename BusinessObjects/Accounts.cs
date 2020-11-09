using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public class Accounts : BusinessObject
    {
        public Accounts()
        {
            AddRule(new ValidateRequired("Username"));
            AddRule(new ValidateLength("Username", 1, 30));

            AddRule(new ValidateRequired("Password"));
            AddRule(new ValidateLength("Password", 1, 30));

            AddRule(new ValidateRequired("Role"));

        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

    }
}
