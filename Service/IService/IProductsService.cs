using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
  public  interface IProductsService
    {
        bool Save(ProductsModel model);
        bool Update(ProductsModel model);
        bool Delete(int ProductId);
        List<ProductsModel> ListAllData();
        ProductsModel GetProductById(int ProductId);
        int GetId();
    }
}
