using ASPEyeCTEvents.App_DAL;
using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.Controllers
{
    public class PlekRepository
    {
        private IPlekContext context;

        public PlekRepository(IPlekContext context)
        {
            this.context = context;
        }

        public List<Plek> GetAll()
        {
            return context.GetAll();
        }

        public bool DeletePlek(int id)
        {
            return context.DeletePlek(id);
        }

        public Plek InsertPlek(Plek plek)
        {
            return context.InsertPlek(plek);
        }

        public bool UpdatePlek(Plek plek)
        {
            return context.UpdatePlek(plek);
        }
    }
}