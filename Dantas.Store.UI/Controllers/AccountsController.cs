using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Dantas.Store.Data.EF;
using Dantas.Store.Domain.Helpers;
using Dantas.Store.UI.ViewModels.Account;

namespace Dantas.Store.UI.Controllers
{

    public class AccountsController : Controller
    {
        private readonly DantasStoreContext _context = new DantasStoreContext();
        

        [HttpGet]
        public ViewResult Login(string returnURL)
        {
            var model = new LoginVM() { ReturnURL = returnURL };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var login = _context.accounts.FirstOrDefault(x => x.Email.ToLower() == model.Email.ToLower());
            if (login == null)
            {
                ModelState.AddModelError("Email", "Email not found.");
            }
            else
            {
                if (login.Password != model.Password.Encrypt())
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                }
            }

            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(login.Name, model.RememberLogin);
                if (!string.IsNullOrEmpty(model.ReturnURL) && Url.IsLocalUrl(model.ReturnURL))
                {
                    return Redirect(model.ReturnURL);
                }
                return RedirectToAction("Index", "Products");
            }
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return Redirect(Url.Action("Index", "Home"));
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}
