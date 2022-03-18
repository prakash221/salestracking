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
    public class DistrictService : IDistrictsService
    {
        public bool delete(int DIstrictId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Districts.Where(a => a.DistrictId == DIstrictId).FirstOrDefault();
                    _context.Districts.Remove(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public DistrictsModel GetDistrictsById(int DIstrictId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Districts.Where(a => a.DistrictId == DIstrictId).Select(a => new DistrictsModel()
                    {
                        DistrictId = a.DistrictId,
                        DistrictName = a.DistrictName
                        
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
                    var data = _context.Districts.Max(a => a.DistrictId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public List<DistrictsModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Districts.Select(a => new DistrictsModel()
                    {
                        DistrictId = a.DistrictId,
                        DistrictName = a.DistrictName
                    }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool save(DistrictsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new District()
                    {

                        DistrictId = model.DistrictId,
                        DistrictName = model.DistrictName
                        
                    };
                    _context.Districts.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool update(DistrictsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Districts.Where(a => a.DistrictId == model.DistrictId).FirstOrDefault();
                    data.DistrictId = model.DistrictId;
                    data.DistrictName = model.DistrictName;
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
