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
        List<DELETEAccount> GetAllAccounts();

        DELETEAccount InsertAccount(DELETEAccount account);

        bool DeleteAccount(int id);

        bool UpdateAccount(DELETEAccount account);
    }
}
