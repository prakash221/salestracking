using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;
using Service.Service;
using Service.IService;
namespace SalesTrackingSystemWEB.Controllers
{
    public class DistributorsController : Controller
    {
        IDistibutorsService DistibutorsService;
        IDistrictsService DistrictsService;
        public DistributorsController()
        {
            DistrictsService = new DistrictService();
            DistibutorsService = new DistributorService();
        }
        // GET: Distributors
        public ActionResult Index()
        {
            var data = DistibutorsService.ListAllData();
            return View("Index", data);
        }
        
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = DistibutorsService.GetDistributorsById(Id);
            var data2 = DistrictsService.ListAllData();
            List<SelectListItem> districtlist = new List<SelectListItem>();
            foreach (DistrictsModel item in data2)
            {
                districtlist.Add(new SelectListItem
                {
                    Text = item.DistrictName,
                    Value = item.DistrictId.ToString()
                });
            }
            ViewBag.Districts = districtlist;
            return View("Edit", data);

        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = DistibutorsService.GetId();
            DistributorsModel dm = new DistributorsModel();
            dm.DistributorId = id;
            var data = DistrictsService.ListAllData();
            List<SelectListItem> districtlist = new List<SelectListItem>();
            foreach(DistrictsModel item in data)
            {
                districtlist.Add(new SelectListItem
                {
                    Text = item.DistrictName, Value = item.DistrictId.ToString()
                });
            }
            ViewBag.Districts = districtlist;
            return View (dm);
        }
       
        [HttpPost]
        public ActionResult Create(DistributorsModel Model)
        {
            DistibutorsService.Save(Model);
            var data = DistibutorsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Edit(DistributorsModel Model)
        {
            DistibutorsService.Update(Model);
            var data = DistibutorsService.ListAllData();
            return View("Index", data);
        }
        
        public ActionResult Delete(int Id)
        {
            DistibutorsService.Delete(Id);
            var data = DistibutorsService.ListAllData();
            return View("Index", data);
        }
    }
}