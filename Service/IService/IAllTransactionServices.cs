using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Service.Service;
using Service.IService;
namespace Service.IService
{
    public interface IAllTransactionServices
    {
        bool SaveTransaction(AllTransactionModel model);
        bool SaveTransactionDetail(AllTransactionModel model);
        bool SaveStock(AllTransactionModel model);
        //bool Update(AllTransactionModel Model);
        //bool Delete(int DistributodId);
        //List<DistributorsModel> ListAllData();
        //DistributorsModel GetDistributorsById(int DistributodId);
        //int GetId();
    }
}
