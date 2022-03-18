using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
  public  interface IDistrictsService
    {
        bool save(DistrictsModel model);
        bool update(DistrictsModel model);
        bool delete(int DIstrictId);
        List<DistrictsModel> ListAllData();
        DistrictsModel GetDistrictsById(int DIstrictId);
        int GetId();
    }
}
