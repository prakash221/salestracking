using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
    public interface IProductCategorieService
    {
        bool Save(ProductcategoriesModel model);
        bool Update(ProductcategoriesModel model);
        bool Delete(int ProductCategoryId);
        List<ProductcategoriesModel> ListAllData();
        ProductcategoriesModel GetProductCategoryById(int ProductCategoryId);
        int GetId();
    }
}
