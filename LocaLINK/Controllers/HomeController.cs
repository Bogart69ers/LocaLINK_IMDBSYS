using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LocaLINK.Controllers
{
    [Authorize(Roles = "User, Worker, Admin")]
    public class HomeController : BaseController
    {
        [AllowAnonymous]
        // GET: Home
        public ActionResult Index()
        {
            return View(_userRepo.GetAll());
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index");

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(User_Account u)
        {
            var user = _userRepo._table.Where(m => m.user_name == u.user_name).FirstOrDefault();

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(u.user_name, false);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "User does not Exist or Incorrect Password");

            return View(u);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}