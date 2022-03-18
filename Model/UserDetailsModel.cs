using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class UserDetailsModel
    {
        public int ProfileDetailId;
        public int ModuleId;
        public bool CreateStatus;
        public bool EditStatus;
        public bool DeleteStatus;
        public bool PrintStatus;
        public bool ViewStatus;

        public int UserId { get; set; }
        public string StaffName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int DistributorID { get; set; }
        public string DistributorName { get; set; }
        public string MobileNo { get; set; }
        public int ProfileId { get; set; }
        public string ProfileName{ get; set; }
        public string EmailId { get; set; }
    }
}
