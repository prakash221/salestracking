
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Service.Service;
using Service.IService;
namespace SalesTrackingSystemWEB.Controllers
{
    public class TransactionController : Controller
    {
        ITransactionService TransactionService;
        public TransactionController()
        {
            TransactionService = new TransactionService();
        }
        // GET: Transaction
        public ActionResult Index()
        {
            var data = TransactionService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = TransactionService.GetTransactionById(Id);
            return View("Edit", data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = TransactionService.GetId();
            TransactionModel tm = new TransactionModel();
            tm.TransactionId = id;
            return View(tm);
        }
        [HttpPost]
        public ActionResult Edit(TransactionModel Model)
        {
            TransactionService.Update(Model);
            var data = TransactionService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(TransactionModel Model)
        {
            TransactionService.Save(Model);
            var data = TransactionService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            TransactionService.Delete(Id);
            var data = TransactionService.ListAllData();
            return View("Index", data);
        }
    }
}