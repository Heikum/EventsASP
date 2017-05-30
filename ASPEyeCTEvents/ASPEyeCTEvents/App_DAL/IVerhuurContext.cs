using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPEyeCTEvents.Models;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IVerhuurContext
    {
        List<Verhuurd> GetAllVerhuurd();
        void Insert(Verhuurd verhuurd);
        void Update(Verhuurd verhuurd);
        void Delete(Verhuurd verhuurd);
    }
}