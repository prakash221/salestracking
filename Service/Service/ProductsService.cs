using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.IService;
using DAL;
using Service.Service;
namespace Service.Service
{
    public class ProductsService : IProductsService
    {
        public bool Delete(int ProductId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Products.Where(a => a.ProductId == ProductId).FirstOrDefault();
                    _context.Products.Remove(data);
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
                    var data = _context.Products.Max(a => a.ProductId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public ProductsModel GetProductById(int ProductId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Products.Where(a => a.ProductId == ProductId).Select(a => new ProductsModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.ProductName,
                        ProductDescription = a.ProductDescription,
                        Unit = a.Unit,
                        ProductCategoryId = a.ProductCategoryId,
                        UnitRate = a.UnitRate,
                        PackRate = a.PackRate,
                        PackSize=a.PackSize
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<ProductsModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from p in _context.Products
                                join pc in _context.ProductCategories on p.ProductCategoryId equals pc.ProductCategoryId

                                select new ProductsModel()
                                {
                                    ProductId = p.ProductId,
                                    ProductName = p.ProductName,
                                    ProductDescription = p.ProductDescription,
                                    CategoryName = pc.CategoryName,
                                    Unit = p.Unit,
                                    ProductCategoryId = pc.ProductCategoryId,
                                    UnitRate = p.UnitRate,
                                    PackRate = p.PackRate,
                                    PackSize = p.PackSize
                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public bool Save(ProductsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Product()
                    {

                        ProductId = model.ProductId,
                        ProductName = model.ProductName,
                        ProductDescription = model.ProductDescription,
                        Unit = model.Unit,
                        ProductCategoryId = model.ProductCategoryId,
                        UnitRate = model.UnitRate,
                        PackRate = model.PackRate,
                        PackSize = model.PackSize
                    };
                    _context.Products.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(ProductsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Products.Where(a => a.ProductId == model.ProductId).FirstOrDefault();
                    data.ProductId = model.ProductId;
                    data.ProductName = model.ProductName;
                    data.ProductDescription = model.ProductDescription;
                    data.Unit = model.Unit;
                    data.ProductCategoryId = model.ProductCategoryId;
                    data.UnitRate = model.UnitRate;
                    data.PackRate = model.PackRate;
                    data.PackSize = model.PackSize;
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
