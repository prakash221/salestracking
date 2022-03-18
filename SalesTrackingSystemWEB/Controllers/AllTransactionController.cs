using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Service.Service;
using Model;
using Service.IService;
namespace SalesTrackingSystemWEB.Controllers
{
    public class AllTransactionController : Controller
    {
        IAllTransactionServices allTransactionServices;
        public AllTransactionController()
        {
            allTransactionServices = new AllTransactionService();
        }
        // GET: AllTransaction
        public ActionResult Index()
        {

            return View();
        }

    }
}