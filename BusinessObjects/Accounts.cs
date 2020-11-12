using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public class Accounts
    {
        public Accounts()
        {

        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

    }
}
