using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.IService
{
   public interface ITransactionService
    {
        bool Save(TransactionModel model);
        bool Update(TransactionModel model);
        bool Delete(int TransactionId);
        List<TransactionModel> ListAllData();
        TransactionModel GetTransactionById(int TransactionId);
        int GetId();
    }
}
