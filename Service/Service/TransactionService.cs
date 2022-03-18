using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Service.IService;
using Service.Service;
namespace Service.Service
{
    public class TransactionService : ITransactionService
    {
        public bool Delete(int TransactionId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Transactions.Where(a => a.TransactionId == TransactionId).FirstOrDefault();
                    _context.Transactions.Remove(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int GetId()
        {
            try
            {
                using (var _context = new salestrackingEntities())
                {
                    var data = _context.Transactions.Max(a => a.TransactionId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public TransactionModel GetTransactionById(int TransactionId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Transactions.Where(a => a.TransactionId == TransactionId).Select(a => new TransactionModel()
                    {
                        TransactionId = a.TransactionId,
                        TransactionLevel = a.TransactionLevel,
                        SupplierId = a.SupplierId,
                        ReceiverId = a.ReceiverId,
                        InvoiceNumber = a.InvoiceNumber,
                        InvoiceDate = a.InvoiceDate,
                        InvoiceEntryDate = a.InvoiceEntryDate
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<TransactionModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Transactions.Select(a => new TransactionModel()
                    {
                                    TransactionId =a.TransactionId,
                                    TransactionLevel = a.TransactionLevel,
                                    SupplierId = a.SupplierId,
                                    ReceiverId = a.ReceiverId,
                                    InvoiceNumber = a.InvoiceNumber,
                                    InvoiceDate = a.InvoiceDate,
                                    InvoiceEntryDate = a.InvoiceEntryDate
                                   
                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(TransactionModel model)
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

        public bool Update(TransactionModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Transactions.Where(a => a.TransactionId == model.TransactionId).FirstOrDefault();
                    data.TransactionId = model.TransactionId;
                    data.TransactionLevel = model.TransactionLevel;
                    data.SupplierId = model.SupplierId;
                    data.ReceiverId = model.ReceiverId;
                    data.InvoiceNumber = model.InvoiceNumber;
                    data.InvoiceDate = model.InvoiceDate;
                    data.InvoiceEntryDate = model.InvoiceEntryDate;
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
