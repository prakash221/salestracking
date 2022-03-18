using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
  public  interface IProfileDetailService
    {
        bool Save(ProfileDetailModel model);
        bool Update(ProfileDetailModel model);
        bool Delete(int ProfiledetailId);
        List<ProfileDetailModel> ListAllData();
        ProfileDetailModel GetProfileDetailById(int ProfileDetail);
        int GetId();
    }
}
