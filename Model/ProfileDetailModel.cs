using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ProfileDetailModel
    {
        public int ProfileDetailId { get; set; }
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public bool CreateStatus { get; set; }
        public bool EditStatus { get; set; }
        public bool DeleteStatus { get; set; }
        public bool PrintStatus { get; set; }
        public bool ViewStatus { get; set; }
    }
}
