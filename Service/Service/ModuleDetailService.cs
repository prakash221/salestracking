using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.IService;
using DAL;
using Service.Service;
namespace Service.Service
{
    public class ModuleDetailService : IModuleDetailService
    {
        public bool Delete(int ModuleId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ModuleDetails.Where(a => a.ModuleId == ModuleId).FirstOrDefault();
                    _context.ModuleDetails.Remove(data);
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
                    var data = _context.ModuleDetails.Max(a => a.ModuleId);
                    int id = Convert.ToInt32(data) + 1;
                    return id;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public ModuleDetailModel GetModuleById(int ModuleId)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ModuleDetails.Where(a => a.ModuleId == ModuleId).Select(a => new ModuleDetailModel()
                    {
                        ModuleId = a.ModuleId,
                        ModuleName = a.ModuleName,
                        Controller = a.Controller,
                        Action = a.Action
                        
                    }).FirstOrDefault();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<ModuleDetailModel> ListAllData()
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ModuleDetails.Select(a => new ModuleDetailModel()
                    {
                        ModuleId = a.ModuleId,
                        ModuleName = a.ModuleName,
                        Controller = a.Controller,
                        Action = a.Action
                        

                    }).ToList();
                    return data;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Save(ModuleDetailModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = new ModuleDetail()
                    {

                        ModuleId = model.ModuleId,
                        ModuleName = model.ModuleName,
                        Controller = model.Controller,
                        Action = model.Action
                       
                    };
                    _context.ModuleDetails.Add(data);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Update(ModuleDetailModel model)
        {
            using (var _context = new salestrackingEntities())
            {
                try
                {
                    var data = _context.ModuleDetails.Where(a => a.ModuleId == model.ModuleId).FirstOrDefault();
                    data.ModuleId = model.ModuleId;
                    data.ModuleName = model.ModuleName;
                    data.Controller = model.Controller;
                    data.Action = model.Action;
                    
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
