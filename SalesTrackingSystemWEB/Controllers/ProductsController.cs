using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Service.IService;
using Service.Service;
using DAL;
namespace SalesTrackingSystemWEB.Controllers
{
    public class ProductsController : Controller
    {
        IProductsService productsService;
        IProductCategorieService ProductCategorieService;
        public ProductsController()
        {
            productsService = new ProductsService();
            ProductCategorieService = new ProductCategoriesService();
        }
        // GET: Products
        public ActionResult Index()
        {
            var data = productsService.ListAllData();
            
            return View("Index", data);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var data = productsService.GetProductById(Id);
            var data2 = ProductCategorieService.ListAllData();
            List<SelectListItem> productcategorylist = new List<SelectListItem>();
            foreach (ProductcategoriesModel item in data2)
            {
                productcategorylist.Add(new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.ProductCategoryId.ToString()
                });
            }
            ViewBag.ProductCategories = productcategorylist;

            return View("Edit", data);

        }
        [HttpGet]
        public ActionResult Create()
        {
            int id = productsService.GetId();
            ProductsModel pm = new ProductsModel();
            pm.ProductId = id;
            var data = ProductCategorieService.ListAllData();
            List<SelectListItem> productcategorylist = new List<SelectListItem>();
            foreach (ProductcategoriesModel item in data)
            {
                productcategorylist.Add(new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.ProductCategoryId.ToString()
                });
            }
            ViewBag.ProductCategories = productcategorylist;
            return View(pm);

        }
        [HttpPost]
        public ActionResult Edit(ProductsModel Model)
        {
            productsService.Update(Model);
            var data = productsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Create(ProductsModel Model)
        {
            productsService.Save(Model);
            var data = productsService.ListAllData();
            return View("Index", data);
        }
        public ActionResult Delete(int Id)
        {
            productsService.Delete(Id);
            var data = productsService.ListAllData();
            return View("Index", data);
        }
    }
}