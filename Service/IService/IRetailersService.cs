using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
   public interface IRetailersService
    {
        bool Save(RetailersModel model);
        bool Update(RetailersModel model);
        bool Delete(int RetailerId);
        List<RetailersModel> ListAllData();
        RetailersModel GetRetailerById(int RetailerId);
        int GetId();
    }
}
