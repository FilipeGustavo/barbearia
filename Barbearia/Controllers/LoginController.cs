using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Barbearia.Controllers
{
    public class LoginController : Controller
    {
        //// GET: Login
        ///// <param name="returnURL"></param>
        ///// <returns></returns>
        //public ActionResult Login(string returnURL)
        //{
        //    /*Recebe a url que o usuário tentou acessar*/
        //    ViewBag.ReturnUrl = returnURL;
        //    return RedirectToAction("Index", "Agenda");
        //}

        public ActionResult Login()
        {
            return View();
        }
    }
}