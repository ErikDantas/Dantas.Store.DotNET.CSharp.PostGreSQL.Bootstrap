using Dantas.Store.Data.EF.Repositories;
using Dantas.Store.Domain.Contracts.Repositories;
using Dantas.Store.Domain.Entities;
using Dantas.Store.UI.ViewModels.Products.AddEdit;
using Dantas.Store.UI.ViewModels.Products.AddEdit.Maps;
using Dantas.Store.UI.ViewModels.Products.Index.Maps;
using System.Linq;
using System.Web.Mvc;

namespace Dantas.Store.UI.Controllers
{
    [Authorize]
    public class ProductsController:Controller
    {
        private readonly IRepositoryProduct _ProductRepository = new RepositoryProductEF();
        private readonly IRepositoryProductType _ProductTypeRepository = new RepositoryProductTypeEF();

        public ViewResult Index()
        {

            var products = _ProductRepository.FindAll().toProductsVM();
            return View(products);
        }

        [HttpGet]
        public ViewResult New(int? id)
        {
            var product = new ProductAddEditVM();
            if (id != null)
            {
                product = _ProductRepository.Get((int)id).toProductAddEditVM();
            }
            var types = _ProductTypeRepository.FindAll();
            ViewBag.Types = types;
            return View(product);
        }

        [HttpPost]
        public ActionResult New(ProductAddEditVM productmodel)
        {
            Product product = productmodel.toProduct();
            if (ModelState.IsValid) { 
                if (product.Id == 0)
                {
                    _ProductRepository.Add(product);
                }
                else
                {
                    _ProductRepository.Edit(product);
                }
             
           
                return RedirectToAction("Index");
            }
            var types = _ProductTypeRepository.FindAll();
            ViewBag.Types = types;
            return View(product);
        }


        public ActionResult confirmDelProd(int id)
        {
            var product = _ProductRepository.Get(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            _ProductRepository.Delete(product);
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            _ProductRepository.Dispose();
            _ProductTypeRepository.Dispose();
        }

    }
}
