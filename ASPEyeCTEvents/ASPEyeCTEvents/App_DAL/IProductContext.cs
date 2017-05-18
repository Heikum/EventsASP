using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPEyeCTEvents.Models;

namespace ASPEyeCTEvents.App_DAL
{
    public interface IProductContext
    {
        List<Product> GetAllProducts();
        void Insert(Product product, ProductCategorie productCategorie);
        void Update(Product product, ProductCategorie productCategorie);
        void Delete(Product product);

    }
}