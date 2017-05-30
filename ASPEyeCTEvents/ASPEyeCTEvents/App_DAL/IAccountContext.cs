using ASPEyeCTEvents.Models;
using ASPEyeCTEvents.App_DAL;
using ASPEyeCTEvents.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IAccountContext
    {
        List<Account> GetAllAccounts();

        Account InsertAccount(Account account);

        bool DeleteAccount(int id);

        bool UpdateAccount(Account account);
    }
}
