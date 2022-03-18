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
    public class RetailersController : Controller
    {
        IRetailersService RetailersService;
        IDistibutorsService DistibutorsService;
        IModuleDetailService ModuleDetailService;
        public RetailersController()
        {
            DistibutorsService = new DistributorService();
            RetailersService = new RetailersService();
            ModuleDetailService = new ModuleDetailService();
        }
        // GET: Retailers
        public ActionResult Index()
        {
            var data = RetailersService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = RetailersService.GetRetailerById(Id);
            var data2 = DistibutorsService.ListAllData();
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (DistributorsModel item in data2)
            {
                listItems.Add(new SelectListItem
                {
                    Text = item.DistributorName,
                    Value = item.DistributorId.ToString()
                });
            }
            ViewBag.Distributors = listItems;
            return View("Edit", data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = RetailersService.GetId();
            RetailersModel dm = new RetailersModel();
            dm.DistributorId = id;
            var data = DistibutorsService.ListAllData();
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (DistributorsModel item in data)
            {
                listItems.Add(new SelectListItem
                {
                    Text = item.DistributorName,
                    Value = item.DistributorId.ToString()
                });
            }
            ViewBag.Distributors = listItems;
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(RetailersModel Model)
        {
            RetailersService.Update(Model);
            var data = RetailersService.ListAllData();

            return View("Index", data);
        }
        public ActionResult Create(RetailersModel Model)
        {
            RetailersService.Save(Model);
            var data = RetailersService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            RetailersService.Delete(Id);
            var data = RetailersService.ListAllData();
            return View("Index", data);
        }
    }
}