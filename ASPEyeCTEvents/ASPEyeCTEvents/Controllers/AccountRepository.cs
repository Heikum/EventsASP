using ASPEyeCTEvents.App_DAL;
using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.Controllers
{
    public class AccountRepository
    {
        private IAccountContext context;

        public AccountRepository(IAccountContext context)
        {
            this.context = context;
        }

        public List<Account> GetAllAccounts()
        {
            return context.GetAllAccounts();
        }

        public Account InsertAccount(Account account)
        {
            return context.InsertAccount(account);
        }

        public bool UpdateAccount(Account account)
        {
            return context.UpdateAccount(account);
        }

        public bool DeleteAccount(int id)
        {
            return context.DeleteAccount(id);
        }
    }
}