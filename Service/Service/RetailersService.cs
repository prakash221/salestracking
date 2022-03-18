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
    public class RetailersService : IRetailersService
    {
      

        public bool Delete(int RetailerId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Retailers.Where(a => a.RetailerId == RetailerId).FirstOrDefault();
                    _context.Retailers.Remove(data);
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
                    var data = _context.Retailers.Max(a => a.RetailerId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public RetailersModel GetRetailerById(int RetailerId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Retailers.Where(a => a.RetailerId == RetailerId).Select(a => new RetailersModel()
                    {
                        RetailerId = a.RetailerId,
                        RetailerName = a.RetailerName,
                        DistributorId = a.DistributorId,
                        State = a.State,
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

        public List<RetailersModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from r in _context.Retailers
                                
                                join d in _context.Distributors on r.DistributorId equals d.DistributorId
                                select new RetailersModel()
                                {
                                    RetailerId = r.RetailerId,
                                    RetailerName = r.RetailerName,
                                    DistributorId = d.DistributorId,
                                    DistributorName=d.DistributorName,
                                    State = r.State,
                                    Address = r.Address,
                                    Email = r.Email,
                                    Phone = r.Phone,
                                    MobileNo = r.MobileNo,
                                    
                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(RetailersModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Retailer()
                    {

                        RetailerId = model.RetailerId,
                        RetailerName = model.RetailerName,
                        DistributorId = model.DistributorId,
                        State = model.State,
                        Address = model.Address,
                        Email = model.Email,
                        Phone = model.Phone,
                        MobileNo = model.MobileNo
                    };
                    _context.Retailers.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(RetailersModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Retailers.Where(a => a.RetailerId == model.RetailerId).FirstOrDefault();
                    data.RetailerId = model.RetailerId;
                    data.RetailerName = model.RetailerName;
                    data.DistributorId = model.DistributorId;
                    data.State = model.State;
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
