using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IBijdrageContext
    {

        List<Bijdrage> GetAllBijdrage();

        bool InsertBijdrage(Bijdrage bijdrage);

        bool DeleteBijdrage(int id);

        bool UpdateBijdrageBericht(Bericht bericht);
        bool UpdateBijdrageBestand(Bestand bestand);

    }
}