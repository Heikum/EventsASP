using ASPEyeCTEvents.App_DAL;
using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.Controllers
{
    public class EventRepository
    {
        private IEventContext context;

        public EventRepository(IEventContext context)
        {
            this.context = context;
        }

        public List<Event> GetAllEvents()
        {
            return context.GetAllEvents();
        }
    }
}