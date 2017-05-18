using ASPEyeCTEvents.App_DAL;
using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.Controllers
{
    public class ReserveringRepository
    {
        private IReserveringContext context;

        public ReserveringRepository(IReserveringContext context)
        {
            this.context = context;
        }

        public List<Reservering> GetAllReserveringen()
        {
            return context.GetAllReserveringen();
        }

        public Reservering InsertReservering(Reservering reserveringen)
        {
            return context.InsertReservering(reserveringen);
        }

        public void UpdateReservering(Reservering reserveringen)
        {
            context.UpdateReservering(reserveringen);
        }

        public void DeleteReservering(Reservering reserveringen)
        {
            context.DeleteReservering(reserveringen);
        }
    }
}