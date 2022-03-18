using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.IService
{
  public  interface IModuleDetailService
    {
        bool Save(ModuleDetailModel model);
        bool Update(ModuleDetailModel model);
        bool Delete(int ModuleId);
        List<ModuleDetailModel> ListAllData();
        ModuleDetailModel GetModuleById(int ModuleId);
        int GetId();
    }
}
