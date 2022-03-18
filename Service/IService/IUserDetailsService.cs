using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.IService
{
  public  interface IUserDetailsService
    {
        bool Save(UserDetailsModel model);
        bool Update(UserDetailsModel model);
        bool Delete(int UserId);
        List<UserDetailsModel> ListAllData();
        UserDetailsModel GetUserDetailsById(int UserId);
        int GetId();
        UserDetailsModel CheckAuthorization(UserDetailsModel model);
    }
}
