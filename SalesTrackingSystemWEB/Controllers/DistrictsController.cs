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
    public class DistrictsController : Controller
    {
        IDistrictsService DistrictsService;
        public DistrictsController()
        {
            DistrictsService = new DistrictService();
        }
        // GET: Districts
        public ActionResult Index()
        {
            var data = DistrictsService.ListAllData();
            return View("Index", data);
        }
        
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = DistrictsService.GetDistrictsById(Id);
            return View("Edit", data);

        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = DistrictsService.GetId();
            DistrictsModel dm = new DistrictsModel();
            dm.DistrictId = id;
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(DistrictsModel Model)
        {
            DistrictsService.update(Model);
            var data = DistrictsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(DistrictsModel Model)
        {
            DistrictsService.save(Model);
            var data = DistrictsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            DistrictsService.delete(Id);
            var data = DistrictsService.ListAllData();
            return View("Index", data);
        }
    }
}