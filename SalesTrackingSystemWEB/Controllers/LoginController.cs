using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.IService;
using Service.Service;
using Model;

namespace SalesTrackingSystemWEB.Controllers
{
    public class LoginController : Controller
    {
        IUserDetailsService UserDetailsService;
        public LoginController()
        {
            UserDetailsService = new UserDetailsService();
        }
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserDetailsModel model)
        {
            var data = UserDetailsService.CheckAuthorization(model);
            if (data != null)
            {
                Session["UserData"] = data;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("ErrPage");
            }
        }
    }
}