using Dantas.Store.UI.Data;
using Dantas.Store.UI.Models;
using System.Linq;
using System.Web.Mvc;

namespace Dantas.Store.UI.Controllers
{
    [Authorize]
    public class ProductsController:Controller
    {
        private readonly DantasStoreContext _context = new DantasStoreContext();

        public ViewResult Index()
        {
            
            var products = _context.products.ToList();
            ViewBag.TotalList = products.Count();
            return View(products);
        }

        [HttpGet]
        public ViewResult New(int? id)
        {
            Product product = new Product();
            if (id != null)
            {
                product = _context.products.Find(id);
            }
            var types = _context.productTypes.ToList();
            ViewBag.Types = types;
            return View(product);
        }

        [HttpPost]
        public ActionResult New(Product product)
        {
            if (ModelState.IsValid) { 
                if (product.Id == 0)
                {
                    _context.products.Add(product);
                }
                else
                {
                    _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                }
                _context.SaveChanges();
           
                return RedirectToAction("Index");
            }
            var types = _context.productTypes.ToList();
            ViewBag.Types = types;
            return View(product);
        }


        public ActionResult confirmDelProd(int id)
        {
            var product = _context.products.Find(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            _context.products.Remove(product);
            _context.SaveChanges();
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}
