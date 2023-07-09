using Expenses.Core.DTO;
using Expenses.DB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Core
{
    public interface IExpensesServices
    {
        Task<List<ExpenseDTO>> GetExpensesAsync();
        ExpenseDTO GetExpense(int id);
        Task<ExpenseDTO> CreateExpenseAsync(Expense expense);
        void DeleteExpense(ExpenseDTO expense);
        Task<ExpenseDTO> EditExpenseAsync(ExpenseDTO expense);
    }
}
