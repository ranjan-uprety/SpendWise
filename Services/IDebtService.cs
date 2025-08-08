using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpendWise.Models;

namespace SpendWise.Services
{
    public interface IDebtService
    {
        Task SaveDebtAsync(Debts debt);

        Task<Debts> LoadUsersTransactionsDebtsAsync(int transactionId);

        Task ClearDebtAsync(int debtId);

    }
}
