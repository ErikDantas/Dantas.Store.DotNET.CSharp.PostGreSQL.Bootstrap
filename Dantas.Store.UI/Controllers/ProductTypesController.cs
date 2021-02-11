using Dantas.Store.Data.EF.Repositories;
using Dantas.Store.Domain.Contracts.Repositories;
using Dantas.Store.UI.ViewModels.ProductTypes;
using Dantas.Store.UI.ViewModels.ProductTypes.Maps;
using System.Web.Mvc;

namespace Dantas.Store.UI.Controllers
{
    [Authorize]
    public class ProductTypesController : Controller
    {
        private readonly IRepositoryProductType _ProductTypeRepository = new RepositoryProductTypeEF();

        public ViewResult Index()
        {
            var producttypes = _ProductTypeRepository.FindAll().toProductTypesVM();

            return View(producttypes);
        }



        [HttpGet]
        public ViewResult AddNewType(int? id)
        {
            var producttype = new ProductTypesVM();
            if (id != null)
            {
                producttype = _ProductTypeRepository.Get((int)id).toProductTypeVM();
            }
            return View(producttype);
        }

        [HttpPost]
        public ActionResult AddNewType(ProductTypesVM prod)
        {
            var producttype = prod.toOneProductType();
            if (ModelState.IsValid)
            {
                if(producttype.Id == 0)
                {
                    _ProductTypeRepository.Add(producttype);
                }
                else
                {
                    _ProductTypeRepository.Edit(producttype);
                }
                return RedirectToAction("Index");
            }
      
            return View(producttype);
        }


        public ActionResult confirmDelProd(int id)
        {
            var product = _ProductTypeRepository.Get(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            _ProductTypeRepository.Delete(product);
            return null;
        }
    }
}
