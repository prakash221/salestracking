using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ModuleDetailModel
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
