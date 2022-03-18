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
    public class UserDetailsController : Controller
    {
        IUserDetailsService UserDetailsService;
        IDistibutorsService DistibutorsService;
        IProfileService ProfileService;
        public UserDetailsController()
        {
            UserDetailsService = new UserDetailsService();
            DistibutorsService = new DistributorService();
            ProfileService = new ProfileService();
        }
        // GET: UserDetails
        public ActionResult Index()
        {
            var data = UserDetailsService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit( int Id)
        {
            var data = UserDetailsService.GetUserDetailsById(Id);
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
            var data3 = ProfileService.ListAllData();
            List<SelectListItem> listItemsp = new List<SelectListItem>();
            foreach (ProfileModel item in data3)
            {
                listItemsp.Add(new SelectListItem
                {
                    Text = item.ProfileName,
                    Value = item.ProfileId.ToString()
                });
            }
            ViewBag.Profiles = listItemsp;
            return View("Edit", data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = UserDetailsService.GetId();
            UserDetailsModel dm = new UserDetailsModel();
            dm.UserId = id;
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
            var data3 = ProfileService.ListAllData();
            List<SelectListItem> listItemsp = new List<SelectListItem>();
            foreach (ProfileModel item in data3)
            {
                listItemsp.Add(new SelectListItem
                {
                    Text = item.ProfileName,
                    Value = item.ProfileId.ToString()
                });
            }
            ViewBag.Profiles = listItemsp;
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(UserDetailsModel Model)
        {
            UserDetailsService.Update(Model);
            var data = UserDetailsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(UserDetailsModel Model)
        {
            UserDetailsService.Save(Model);
            var data = UserDetailsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            UserDetailsService.Delete(Id);
            var data = UserDetailsService.ListAllData();
            return View("Index", data);
        }
    }
}