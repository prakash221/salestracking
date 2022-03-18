    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class DistributorsModel
    {
        public int DistributorId { get; set; }
        public string DistributorName { get; set; }
        public string State { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public string DistictName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<int> MobileNo { get; set; }
    }
}
