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
    public class ModuleDetailController : Controller
    {
        IModuleDetailService ModuleDetailService;
        public ModuleDetailController()
        {
            ModuleDetailService = new ModuleDetailService();
        }
        // GET: ModuleDetail
        public ActionResult Index()
        {

            var data = ModuleDetailService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = ModuleDetailService.GetModuleById(Id);
            return View("Edit", data);

        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = ModuleDetailService.GetId();
            ModuleDetailModel dm = new ModuleDetailModel();
            dm.ModuleId = id;
            return View(dm);
        }

        [HttpPost]
        public ActionResult Edit(ModuleDetailModel Model)
        {
            ModuleDetailService.Update(Model);
            var data = ModuleDetailService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(ModuleDetailModel Model)
        {
            ModuleDetailService.Save(Model);
            var data = ModuleDetailService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            ModuleDetailService.Delete(Id);
            var data = ModuleDetailService.ListAllData();
            return View("Index", data);
        }
    }
}