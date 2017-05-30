using ASPEyeCTEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IPersoonContext
    {
        List<Persoon> GetAllPersonen();

        Persoon InsertPersoon(Persoon persoon);

        bool UpdatePersoon(Persoon persoon);

        bool DeletePersoon(int id);
    }
}
