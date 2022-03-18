using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Service;
using Service.IService;
using DAL;
namespace Service.IService
{
  public  interface ISupplierService
    {
        bool Save(SupplierModel model);
        bool Update(SupplierModel model);
        bool Delete(int SupplierID);
        List<SupplierModel> ListAllData();
        SupplierModel GetSupplierById(int SupplierID);
        int GetId();
    }
}
