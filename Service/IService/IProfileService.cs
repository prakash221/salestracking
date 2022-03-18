using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
  public  interface IProfileService
    {
        bool Save(ProfileModel model);
        bool Update(ProfileModel model);
        bool Delete(int ProfileId);
        List<ProfileModel> ListAllData();
        ProfileModel GetProfileById(int ProfileId);
        int GetId();
    }
}
