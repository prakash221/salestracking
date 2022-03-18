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
    public class TransactionDetailService : ITransactionDetailService
    {
        public bool Delete(int TransactionDetailId)
        {
          
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.TransactionDetails.Where(a => a.TransactionDetailID == TransactionDetailId).FirstOrDefault();
                    _context.TransactionDetails.Remove(data);
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
                    var data = _context.TransactionDetails.Max(a => a.TransactionDetailID);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public TransactionDetailModel GetTransactionDetailById(int TransactiondetailId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.TransactionDetails.Where(a => a.TransactionDetailID == TransactiondetailId).Select(a => new TransactionDetailModel()
                    {
                        TransactionDetailID = a.TransactionDetailID,
                        TransactionId = a.TransactionId,
                        ProductId = a.ProductId,
                        Quantity = a.Quantity,
                        Units = a.Units
                        }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<TransactionDetailModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from td in _context.TransactionDetails
                                join p in _context.Products on td.ProductId equals p.ProductId
                                select new TransactionDetailModel()
                                {
                                    TransactionDetailID = td.TransactionDetailID,
                                    TransactionId = td.TransactionId,
                                    ProductId = p.ProductId,
                                    ProductName=p.ProductName,
                                    Quantity = td.Quantity,
                                    Units = td.Units
                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(TransactionDetailModel model)
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

        public bool Update(Model.TransactionDetailModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.TransactionDetails.Where(a => a.TransactionDetailID == model.TransactionDetailID).FirstOrDefault();
                    data.TransactionDetailID = model.TransactionDetailID;
                    data.TransactionId = model.TransactionId;
                    data.ProductId = model.ProductId;
                    data.Quantity = model.Quantity;
                    data.Units = model.Units;
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
