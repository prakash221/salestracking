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
    public class DistributorService : IDistibutorsService
    {
        public bool Delete(int DistributodId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Distributors.Where(a => a.DistributorId == DistributodId).FirstOrDefault();
                    _context.Distributors.Remove(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DistributorsModel GetDistributorsById(int DistributodId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Distributors.Where(a => a.DistributorId == DistributodId).Select(a => new DistributorsModel()
                    {
                        DistributorId = a.DistributorId,
                        DistributorName = a.DistributorName,
                        State = a.State,
                        DistrictId = a.DistrictId,
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

        public int GetId()
        {
            try
            {
                using (var _context = new salestrackingEntities())
                {
                    var data = _context.Distributors.Max(a => a.DistributorId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public List<DistributorsModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from d in _context.Distributors
                                join dis in _context.Districts on d.DistrictId equals dis.DistrictId
                                select new DistributorsModel()
                                {
                                    DistributorId = d.DistributorId,
                                    DistributorName = d.DistributorName,
                                    DistrictId = dis.DistrictId,
                                    DistictName =  dis.DistrictName,
                                    Address = d.Address,
                                    Email = d.Email,
                                    Phone=d.Phone,
                                    MobileNo=d.MobileNo

                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(DistributorsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Distributor()
                    {

                        DistributorId = model.DistributorId,
                        DistributorName = model.DistributorName,
                        State = model.State,
                        DistrictId = model.DistrictId,
                        Address = model.Address,
                        Email = model.Email,
                        Phone = model.Phone,
                        MobileNo = model.MobileNo
                    };
                    _context.Distributors.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(DistributorsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Distributors.Where(a => a.DistributorId == model.DistributorId).FirstOrDefault();
                    data.DistributorId = model.DistributorId;
                    data.DistributorName = model.DistributorName;
                    data.State = model.State;
                    data.DistrictId = model.DistrictId;
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
