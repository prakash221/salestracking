using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
    public interface IDistibutorsService
    {
        bool Save(DistributorsModel Model);
        bool Update(DistributorsModel Model);
        bool Delete(int DistributodId);
        List<DistributorsModel> ListAllData();
        DistributorsModel GetDistributorsById(int DistributodId);
        int GetId();
    }

  
}