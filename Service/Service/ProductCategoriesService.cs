using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Service.IService;
using Service.Service;
namespace Service.Service
{
    public class ProductCategoriesService : IProductCategorieService
    {
        public bool Delete(int ProductCategoryId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProductCategories.Where(a => a.ProductCategoryId == ProductCategoryId).FirstOrDefault();
                    _context.ProductCategories.Remove(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int GetId()
        {
            try
            {
                using (var _context = new salestrackingEntities())
                {
                    var data = _context.ProductCategories.Max(a => a.ProductCategoryId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public ProductcategoriesModel GetProductCategoryById(int ProductCategoryId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProductCategories.Where(a => a.ProductCategoryId == ProductCategoryId).Select(a => new ProductcategoriesModel()
                    {
                        ProductCategoryId = a.ProductCategoryId,
                        CategoryName = a.CategoryName
                        }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<ProductcategoriesModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProductCategories.Select(a => new ProductcategoriesModel()
                    {
                        ProductCategoryId = a.ProductCategoryId,
                        CategoryName = a.CategoryName
                        

                    }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(ProductcategoriesModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new ProductCategory()
                    {

                        ProductCategoryId = model.ProductCategoryId,
                        CategoryName = model.CategoryName
                       
                    };
                    _context.ProductCategories.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(ProductcategoriesModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProductCategories.Where(a => a.ProductCategoryId == model.ProductCategoryId).FirstOrDefault();
                    data.ProductCategoryId = model.ProductCategoryId;
                    data.CategoryName = model.CategoryName;
                    
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
