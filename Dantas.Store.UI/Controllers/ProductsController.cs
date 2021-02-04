using Dantas.Store.UI.Data;
using Dantas.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Dantas.Store.UI.Controllers
{
    public class ProductsController:Controller
    {
        public ViewResult Index()
        {
            
            IList<Product> products = null;
            using (var context = new DantasStoreContext())
            {
                products = context.produtos.ToList();
            }
                           
            
            return View(products);
        }

        [HttpGet]
        public ViewResult New()
        {
            return View();
        }

        [HttpPost]
        public ViewResult New(Product product)
        {
            return View();
        }


    }
}
