using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class ProductsModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<int> ProductCategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> UnitRate { get; set; }
        public Nullable<int> PackRate { get; set; }
        public Nullable<int> PackSize { get; set; }
    }
}
