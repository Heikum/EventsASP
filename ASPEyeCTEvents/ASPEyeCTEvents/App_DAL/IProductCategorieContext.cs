using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPEyeCTEvents.Models;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IProductCategorieContext
    {
        List<ProductCategorie>GetAllCategories();
        void Insert(ProductCategorie productCategorie);
        void Update(ProductCategorie productCategorie);
        void Delete(ProductCategorie productCategorie);
    }
}