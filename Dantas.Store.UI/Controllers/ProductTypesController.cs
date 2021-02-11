using Dantas.Store.Data.EF.Repositories;
using Dantas.Store.Domain.Contracts.Repositories;
using Dantas.Store.Domain.Entities;
using System.Web.Mvc;

namespace Dantas.Store.UI.Controllers
{
    public class ProductTypesController : Controller
    {
        private readonly IRepositoryProductType _ProductTypeRepository = new RepositoryProductTypeEF();

        public ViewResult Index()
        {
            var producttypes = _ProductTypeRepository.FindAll();

            return View(producttypes);
        }



        [HttpGet]
        public ViewResult AddNewType()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewType(ProductType prod)
        {
            var producttype = prod;
            return View();
        }
       

        
    }
}
