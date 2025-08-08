using SpendWise.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace SpendWise.Services
{
   public interface ITransactionService
    {

        Task<int> SaveTransactionAsync(Transactions transaction);

        Task<List<Transactions>> LoadUsersTransactionsAsync(int userId);
    }
}
