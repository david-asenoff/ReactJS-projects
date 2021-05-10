using Expenses.DB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Core
{
    public interface IExpensesServices
    {
        Task<List<Expense>> GetExpensesAsync();
        Expense GetExpense(int id);
        Task<Expense> CreateExpenseAsync(Expense expense);
        void DeleteExpense(Expense expense);
        Task<Expense> EditExpenseAsync(Expense expense);
    }
}
