using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Registration.Models
{
    public class InfoHolder
    {
        public List<Account> Accounts;

        public InfoHolder()
        {
            Accounts = new List<Account>();
            Accounts.Add(new Account { Id = 1, Name = "My name 1", Age = 12 });
            Accounts.Add(new Account { Id = 2, Name = "My name 2", Age = 12 });
            Accounts.Add(new Account { Id = 3, Name = "My name 3", Age = 12 });
        }
    }
}