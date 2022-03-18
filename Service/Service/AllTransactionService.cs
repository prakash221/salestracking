using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Service.Service;
using Service.IService;

namespace Service.Service
{
    public class AllTransactionService : IAllTransactionServices
    {
        public bool SaveStock(AllTransactionModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Stock()
                    {
                        StockID = model.StockID,
                        StockQuantity = model.StockQuantity,
                        DistributorID = model.DistributorId,
                        ProductID = model.ProductId,
                        
                    };
                    _context.Stocks.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool SaveTransaction(AllTransactionModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Transaction()
                    {

                        TransactionId = model.TransactionId,
                        TransactionLevel = model.TransactionLevel,
                        SupplierId = model.SupplierId,
                        ReceiverId = model.ReceiverId,
                        InvoiceNumber = model.InvoiceNumber,
                        InvoiceDate = model.InvoiceDate,
                        InvoiceEntryDate = model.InvoiceEntryDate
                    };
                    _context.Transactions.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool SaveTransactionDetail(AllTransactionModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new TransactionDetail()
                    {

                        TransactionDetailID = model.TransactionDetailID,
                        TransactionId = model.TransactionId,
                        ProductId = model.ProductId,
                        Quantity = model.Quantity,
                        Units = model.Units
                    };
                    _context.TransactionDetails.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
