﻿using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IEventContext
    {
        List<Event> GetAllEvents();
    }
}