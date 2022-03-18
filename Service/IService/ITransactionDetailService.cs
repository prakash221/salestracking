using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Service.IService
{
   public interface ITransactionDetailService
    {
        bool Save(TransactionDetailModel model);
        bool Update(TransactionDetailModel model);
        bool Delete(int TransactionDetailId);
        List<TransactionDetailModel> ListAllData();
        TransactionDetailModel GetTransactionDetailById(int TransactiondetailId);
        int GetId();
    }
}
