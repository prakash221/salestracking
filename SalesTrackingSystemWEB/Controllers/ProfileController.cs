using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Service.Service;
using Service.IService;
using DAL;
namespace SalesTrackingSystemWEB.Controllers
{
    public class ProfileController : Controller
    {
        IProfileService ProfileService;
        IProfileDetailService ProfileDetailService;
        public ProfileController()
        {
            ProfileService = new ProfileService();
            ProfileDetailService = new ProfileDetailService();
        }
        // GET: Profile
        public ActionResult Index()
        {
            var data = ProfileService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = ProfileService.GetProfileById(Id);
            return View("Edit", data);
        }
        [HttpGet]
        public ActionResult Create()
        {

            int id = ProfileService.GetId();
            ProfileModel pm = new ProfileModel();
            pm.ProfileId = id;
            return View(pm);
        }
        [HttpPost]
        public ActionResult Edit(ProfileModel Model)
        {
            ProfileService.Update(Model);
            var data = ProfileService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(ProfileModel Model)
        {
            ProfileService.Save(Model);
            var data = ProfileService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            ProfileService.Delete(Id);
            var data = ProfileService.ListAllData();
            return View("Index", data);
        }
    }
}