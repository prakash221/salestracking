using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class SupplierModel
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public Nullable<int> DistributorID { get; set; }
        public string DistributorName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobileNo { get; set; }
    }
}
