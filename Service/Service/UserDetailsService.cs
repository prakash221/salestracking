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
    public class UserDetailsService : IUserDetailsService
    {
        public UserDetailsModel CheckAuthorization(UserDetailsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from a in _context.UserDetails.Where(a => a.UserName == model.UserName && a.Password == model.Password)
                                select new UserDetailsModel()

                                {
                                    UserId = a.UserId,
                                    StaffName = a.StaffName,
                                    UserName = a.UserName,
                                    Password = a.Password,
                                    DistributorID = a.DistributorID,
                                    MobileNo = a.MobileNo,
                                    ProfileId = a.ProfileId,
                                    EmailId = a.EmailId

                                }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Delete(int UserId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.UserDetails.Where(a => a.UserId == UserId).FirstOrDefault();
                    _context.UserDetails.Remove(data);
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
                    var data = _context.UserDetails.Max(a => a.UserId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public UserDetailsModel GetUserDetailsById(int UserId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.UserDetails.Where(a => a.UserId == UserId).Select(a => new UserDetailsModel()
                    {
                        UserId = a.UserId,
                        StaffName = a.StaffName,
                        UserName = a.UserName,
                        Password = a.Password,
                        DistributorID = a.DistributorID,
                        MobileNo = a.MobileNo,
                        ProfileId = a.ProfileId,
                        EmailId = a.EmailId
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<UserDetailsModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from ud in _context.UserDetails
                                join p in _context.Profiles on ud.ProfileId equals p.ProfileId
                                join d in _context.Distributors on ud.DistributorID equals d.DistributorId
                                select new UserDetailsModel()
                                {
                                    UserId = ud.UserId,
                                    StaffName = ud.StaffName,
                                    UserName = ud.UserName,
                                    Password = ud.Password,
                                    DistributorID = d.DistributorId,
                                    DistributorName = d.DistributorName,
                                    MobileNo = ud.MobileNo,
                                    ProfileId = p.ProfileId,
                                    ProfileName = p.ProfileName,
                                    EmailId = ud.EmailId
                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(UserDetailsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new UserDetail()
                    {

                        UserId = model.UserId,
                        StaffName = model.StaffName,
                        UserName = model.UserName,
                        Password = model.Password,
                        DistributorID = model.DistributorID,
                        MobileNo = model.MobileNo,
                        ProfileId = model.ProfileId,
                        EmailId = model.EmailId
                    };
                    _context.UserDetails.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(UserDetailsModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.UserDetails.Where(a => a.UserId == model.UserId).FirstOrDefault();
                    data.UserId = model.UserId;
                    data.StaffName = model.StaffName;
                    data.UserName = model.UserName;
                    data.Password = model.Password;
                    data.DistributorID = model.DistributorID;
                    data.MobileNo = model.MobileNo;
                    data.ProfileId = model.ProfileId;
                    data.EmailId = model.EmailId;
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
