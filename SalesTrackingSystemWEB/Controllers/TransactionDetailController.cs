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
    public class TransactionDetailController : Controller
    {
        ITransactionDetailService TransactionDetailService;
        ITransactionService TransactionService;
    
        public TransactionDetailController()
        {
            TransactionDetailService = new TransactionDetailService();
            TransactionService = new TransactionService();
        }
        // GET: TransactionDetail
        public ActionResult Index()
        {
            var data = TransactionDetailService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = TransactionDetailService.GetTransactionDetailById(Id);
            return View("Edit", data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = TransactionDetailService.GetId();
            TransactionDetailModel dm = new TransactionDetailModel();
            dm.TransactionDetailID = id;
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(TransactionDetailModel Model)
        {
            TransactionDetailService.Update(Model);
            var data = TransactionDetailService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(TransactionDetailModel Model)
        {
            TransactionDetailService.Save(Model);
            var data = TransactionDetailService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            TransactionDetailService.Delete(Id);
            var data = TransactionDetailService.ListAllData();
            return View("Index", data);
        }
    }
}