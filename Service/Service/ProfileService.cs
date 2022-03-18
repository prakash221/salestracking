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
    public class ProfileService : IProfileService
    {
        public bool Delete(int ProfileId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Profiles.Where(a => a.ProfileId == ProfileId).FirstOrDefault();
                    _context.Profiles.Remove(data);
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
                    var data = _context.Profiles.Max(a => a.ProfileId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public ProfileModel GetProfileById(int ProfileId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Profiles.Where(a => a.ProfileId == ProfileId).Select(a => new ProfileModel()
                    {
                        ProfileId = a.ProfileId,
                        ProfileName = a.ProfileName,
                        Description = a.Description,
                        CreatedBy = a.CreatedBy,
                        CreatedDate = a.CreatedDate
                       
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<ProfileModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Profiles.Select(a => new ProfileModel()
                    {
                        ProfileId = a.ProfileId,
                        ProfileName = a.ProfileName,
                        Description = a.Description,
                        CreatedBy = a.CreatedBy,
                        CreatedDate = a.CreatedDate
                        
                    }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(ProfileModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new Profile()
                    {

                        ProfileId = model.ProfileId,
                        ProfileName = model.ProfileName,
                        Description = model.Description,
                        CreatedBy = model.CreatedBy,
                        CreatedDate = model.CreatedDate
                        
                    };
                    _context.Profiles.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(ProfileModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.Profiles.Where(a => a.ProfileId == model.ProfileId).FirstOrDefault();
                    data.ProfileId = model.ProfileId;
                    data.ProfileName = model.ProfileName;
                    data.Description = model.Description;
                    data.CreatedBy = model.CreatedBy;
                    data.CreatedDate = model.CreatedDate;
                    
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
