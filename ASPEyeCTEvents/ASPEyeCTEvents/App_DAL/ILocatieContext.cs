using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPEyeCTEvents.Models;

namespace ASPEyeCTEvents
{
    public interface ILocatieContext
    {
        List<Locatie> GetAllLocations();

        Locatie InsertLocatie(Locatie locatie);

        bool DeleteLocatie(int id);

        bool UpdateLocatie(Locatie locatie);

    }
}
