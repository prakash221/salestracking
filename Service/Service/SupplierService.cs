using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using Service.Service;
using Service.IService;
namespace Service.Service
{
  public  class SupplierService:ISupplierService
    {
        public bool Delete(int SupplierID)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Suppliers.Where(a => a.SupplierID == SupplierID).FirstOrDefault();
                    _context.Suppliers.Remove(data);
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
                    var data = _context.Suppliers.Max(a => a.SupplierID);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public SupplierModel GetSupplierById(int SupplierID)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Suppliers.Where(a => a.SupplierID == SupplierID).Select(a => new SupplierModel()
                    {
                        SupplierID = a.SupplierID,
                        SupplierName = a.SupplierName,
                        DistributorID = a.DistributorID,
                        Address = a.Address,
                        Email = a.Email,
                        Phone = a.Phone,
                        MobileNo = a.MobileNo
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<SupplierModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from s in _context.Suppliers
                                join dist in _context.Distributors on s.DistributorID equals dist.DistributorId
                                select new SupplierModel()
                                {
                                    SupplierID = s.SupplierID,
                                    SupplierName = s.SupplierName,
                                    DistributorID = dist.DistributorId,
                                    DistributorName = dist.DistributorName,
                                    Address = s.Address,
                                    Email = s.Email,
                                    Phone = s.Phone,
                                    MobileNo = s.MobileNo

                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(SupplierModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Supplier()
                    {

                        SupplierID = model.SupplierID,
                        SupplierName = model.SupplierName,
                        DistributorID = model.DistributorID,
                        Address = model.Address,
                        Email = model.Email,
                        Phone = model.Phone,
                        MobileNo = model.MobileNo
                    };
                    _context.Suppliers.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(SupplierModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Suppliers.Where(a => a.SupplierID == model.SupplierID).FirstOrDefault();
                    data.SupplierID = model.SupplierID;
                    data.SupplierName = model.SupplierName;
                    data.DistributorID = model.DistributorID;
                    data.Address = model.Address;
                    data.Email = model.Email;
                    data.Phone = model.Phone;
                    data.MobileNo = model.MobileNo;
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
