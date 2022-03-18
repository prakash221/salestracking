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
    public class ProfileDetailService : IProfileDetailService
    {
        public bool Delete(int ProfiledetailId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProfileDetails.Where(a => a.ProfileDetailId == ProfiledetailId).FirstOrDefault();
                    _context.ProfileDetails.Remove(data);
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
                    var data = _context.ProfileDetails.Max(a => a.ProfileDetailId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public Model.ProfileDetailModel GetProfileDetailById(int ProfileDetail)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProfileDetails.Where(a => a.ProfileDetailId == ProfileDetail).Select(a => new ProfileDetailModel()
                    {
                        ProfileDetailId = a.ProfileDetailId,
                        ProfileId = a.ProfileId,
                        ModuleId = a.ModuleId,
                        CreateStatus = a.CreateStatus,
                        EditStatus = a.EditStatus,
                        DeleteStatus = a.DeleteStatus,
                        PrintStatus = a.PrintStatus,
                        ViewStatus=a.ViewStatus
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Model.ProfileDetailModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = (from pd in _context.ProfileDetails
                                join p in _context.Profiles on pd.ProfileId equals p.ProfileId
                                join md in _context.ModuleDetails on pd.ModuleId equals md.ModuleId
                                select new ProfileDetailModel()
                                {
                                    ProfileDetailId = pd.ProfileDetailId,
                                    ProfileId = p.ProfileId,
                                    ProfileName = p.ProfileName,
                                    ModuleId = md.ModuleId,
                                    ModuleName = md.ModuleName,
                                    CreateStatus = pd.CreateStatus,
                                    EditStatus = pd.EditStatus,
                                    DeleteStatus = pd.DeleteStatus,
                                    PrintStatus = pd.PrintStatus,
                                    ViewStatus = pd.ViewStatus
                                }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(Model.ProfileDetailModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new ProfileDetail()
                    {

                        ProfileDetailId = model.ProfileDetailId,
                        ProfileId = model.ProfileId,
                        ModuleId = model.ModuleId,
                        CreateStatus = model.CreateStatus,
                        EditStatus = model.EditStatus,
                        DeleteStatus = model.DeleteStatus,
                        PrintStatus = model.PrintStatus,
                        ViewStatus = model.ViewStatus
                    };
                    _context.ProfileDetails.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(Model.ProfileDetailModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ProfileDetails.Where(a => a.ProfileDetailId == model.ProfileDetailId).FirstOrDefault();
                    data.ProfileDetailId = model.ProfileDetailId;
                    data.ProfileId = model.ProfileId;
                    data.ModuleId = model.ModuleId;
                    data.CreateStatus = model.CreateStatus;
                    data.EditStatus = model.EditStatus;
                    data.DeleteStatus = model.DeleteStatus;
                    data.PrintStatus = model.PrintStatus;
                    data.ViewStatus = model.ViewStatus;
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
