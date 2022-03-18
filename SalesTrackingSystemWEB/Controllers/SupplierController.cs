using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Service.Service;
using Service.IService;
using Model;
namespace SalesTrackingSystemWEB.Controllers
{
    public class SupplierController : Controller
    {
        ISupplierService SupplierService;
        IDistibutorsService DistibutorsService;
        public SupplierController()
        {
            SupplierService = new SupplierService();
            DistibutorsService = new DistributorService();
        }
        // GET: Supplier
        public ActionResult Index()
        {
            var data = SupplierService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = SupplierService.GetSupplierById(Id);
            var data2 = DistibutorsService.ListAllData();
            List<SelectListItem> distributorlist = new List<SelectListItem>();
            foreach (DistributorsModel item in data2)
            {
                distributorlist.Add(new SelectListItem
                {
                    Text = item.DistributorName,
                    Value = item.DistributorId.ToString()
                });
            }
            ViewBag.Distributors = distributorlist;
            return View("Edit", data);

        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = SupplierService.GetId();
            SupplierModel sm = new SupplierModel();
            sm.SupplierID = id;
            var data2 = DistibutorsService.ListAllData();
            List<SelectListItem> distributorlist = new List<SelectListItem>();
            foreach (DistributorsModel item in data2)
            {
                distributorlist.Add(new SelectListItem
                {
                    Text = item.DistributorName,
                    Value = item.DistributorId.ToString()
                });
            }
            ViewBag.Distributors = distributorlist;
            return View(sm);
        }

        [HttpPost]
        public ActionResult Create(SupplierModel Model)
        {
            SupplierService.Save(Model);
            var data = SupplierService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Edit(SupplierModel Model)
        {
            SupplierService.Update(Model);
            var data = SupplierService.ListAllData();
            return View("Index", data);
        }

        public ActionResult Delete(int Id)
        {
            SupplierService.Delete(Id);
            var data = SupplierService.ListAllData();
            return View("Index", data);
        }
    }
}