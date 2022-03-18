using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AllTransactionModel
    {
        public int TransactionDetailID { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public string Units { get; set; }

        public Nullable<short> TransactionLevel { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Nullable<int> ReceiverId { get; set; }
        public string ReceiverName { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> InvoiceEntryDate { get; set; }

        public int StockID { get; set; }
        public int StockQuantity { get; set; }
        public int DistributorId { get; set; }

    }
}
