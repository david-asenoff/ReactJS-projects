using Expenses.Core.DTO;
using Expenses.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Core
{
    public class ExpensesServices : IExpensesServices
    {
        private readonly AppDbContext context;
        private readonly DB.User user;

        public ExpensesServices(AppDbContext context,
                                  IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.user = context.Users
                .First(x => x.Username == httpContextAccessor.HttpContext.User.Identity.Name);
        }

        public async Task<ExpenseDTO> CreateExpenseAsync(Expense expense)
        {
            expense.User = user;
            await context.Expenses.AddAsync(expense);
            await context.SaveChangesAsync();
            return (ExpenseDTO)expense;
        }

        public void DeleteExpense(ExpenseDTO expense)
        {
            var dbExpense = context.Expenses.First(x => x.User.Id == user.Id && x.Id == expense.Id);
            context.Expenses.Remove(dbExpense);
            context.SaveChanges();
        }

        public async Task<ExpenseDTO> EditExpenseAsync(ExpenseDTO expense)
        {
            var dbExpense = context.Expenses.First(x => x.User.Id == user.Id && x.Id == expense.Id);
            dbExpense.Description = expense.Description;
            dbExpense.Amount = expense.Amount;
            await context.SaveChangesAsync();
            return expense;
        }

        public ExpenseDTO GetExpense(int id)
        {
            return context.Expenses
                .Where(x => x.User.Id == user.Id && x.Id == id)
                .Select(x => (ExpenseDTO)x)
                .First();
        }

        public async Task<List<ExpenseDTO>> GetExpensesAsync()
        {
            return await context.Expenses
                .Where(x => x.User.Id == user.Id)
                .Select(x => (ExpenseDTO)x)
                .ToListAsync();
        }
    }
}
