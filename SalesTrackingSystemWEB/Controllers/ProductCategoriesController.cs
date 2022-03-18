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
    public class ProductCategoriesController : Controller
    {
        IProductCategorieService ProductCategorieService;
        public ProductCategoriesController()
        {
            ProductCategorieService = new ProductCategoriesService();
        }
        // GET: ProductCategories
        public ActionResult Index()
        {
           var data=ProductCategorieService.ListAllData();
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = ProductCategorieService.GetProductCategoryById(Id);
            return View("Edit", data);

        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = ProductCategorieService.GetId();
            ProductcategoriesModel dm = new ProductcategoriesModel();
            dm.ProductCategoryId = id;
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(ProductcategoriesModel Model)
        {
            ProductCategorieService.Update(Model);
            var data = ProductCategorieService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(ProductcategoriesModel Model)
        {
            ProductCategorieService.Save(Model);
            var data = ProductCategorieService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            ProductCategorieService.Delete(Id);
            var data = ProductCategorieService.ListAllData();
            return View("Index", data);
        }
    }
}