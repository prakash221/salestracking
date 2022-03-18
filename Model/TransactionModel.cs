using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class TransactionModel
    {
        public int TransactionId { get; set; }
        public Nullable<short> TransactionLevel { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> ReceiverId { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> InvoiceEntryDate { get; set; }
    }
}
