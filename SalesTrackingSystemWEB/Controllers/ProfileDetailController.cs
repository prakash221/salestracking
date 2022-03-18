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
    public class ProfileDetailController : Controller
    {
        IProfileDetailService ProfileDetailService;
        IProfileService ProfileService;
        IModuleDetailService ModuleDetailService;
        public ProfileDetailController()
        {
            ProfileDetailService = new ProfileDetailService();
            ProfileService = new ProfileService();
            ModuleDetailService = new ModuleDetailService();
        }
        // GET: ProfileDetail
        public ActionResult Index()
        {
            var data = ProfileDetailService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = ProfileDetailService.GetProfileDetailById(Id);
            var data2 = ProfileService.ListAllData();
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (ProfileModel item in data2)
            {
                listItems.Add(new SelectListItem
                {
                    Text = item.ProfileName,
                    Value = item.ProfileId.ToString()
                });
            }
            ViewBag.Profiles = listItems;
            var data3 = ModuleDetailService.ListAllData();
            List<SelectListItem> listItemsm = new List<SelectListItem>();
            foreach (ModuleDetailModel item in data3)
            {
                listItemsm.Add(new SelectListItem
                {
                    Text = item.ModuleName,
                    Value = item.ModuleId.ToString()
                });
            }
            ViewBag.ModuleDetail = listItemsm;

            return View("Edit", data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = ProfileDetailService.GetId();
            ProfileDetailModel pdm = new ProfileDetailModel();
            pdm.ProfileDetailId = id;
            var data = ProfileService.ListAllData();
            List<SelectListItem> Profilelist = new List<SelectListItem>();
            foreach (ProfileModel item in data)
            {
                Profilelist.Add(new SelectListItem
                {
                    Text = item.ProfileName,
                    Value = item.ProfileId.ToString()
                });
            }
            ViewBag.Profiles = Profilelist;
            var data3 = ModuleDetailService.ListAllData();
            List<SelectListItem> listItemsm = new List<SelectListItem>();
            foreach (ModuleDetailModel item in data3)
            {
                listItemsm.Add(new SelectListItem
                {
                    Text = item.ModuleName,
                    Value = item.ModuleId.ToString()
                });
            }
            ViewBag.ModuleDetail = listItemsm;

            return View(pdm);
            
        }
        [HttpPost]
        public ActionResult Edit(ProfileDetailModel Model)
        {
            ProfileDetailService.Update(Model);
            var data = ProfileDetailService.ListAllData();
                        return View("Index", data);
        }
        public ActionResult Create(ProfileDetailModel Model)
        {
            ProfileDetailService.Save(Model);
            var data = ProfileDetailService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            ProfileDetailService.Delete(Id);
            var data = ProfileDetailService.ListAllData();
            return View("Index", data);
        }
    }
}