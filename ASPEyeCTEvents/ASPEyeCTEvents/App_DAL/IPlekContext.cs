using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IPlekContext
    {
        List<Plek> GetAll();

        Plek InsertPlek(Plek plek);

        bool DeletePlek(int id);

        bool UpdatePlek(Plek plek);

    }
}