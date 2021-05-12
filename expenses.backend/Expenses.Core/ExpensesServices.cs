using Expenses.DB;
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

        public ExpensesServices(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Expense> CreateExpenseAsync(Expense expense)
        {
            await context.Expenses.AddAsync(expense);
            await context.SaveChangesAsync();
            return expense;
        }

        public void DeleteExpense(Expense expense)
        {
            context.Expenses.Remove(expense);
            context.SaveChanges();
        }

        public async Task<Expense> EditExpenseAsync(Expense expense)
        {
            var dbExpense = await context.Expenses.FirstOrDefaultAsync(x => x.Id == expense.Id);
            dbExpense.Description = expense.Description;
            dbExpense.Amount = expense.Amount;
            await context.SaveChangesAsync();
            return dbExpense;
        }

        public Expense GetExpense(int id)
        {
            return context.Expenses.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<Expense>> GetExpensesAsync()
        {
            return await context.Expenses.ToListAsync();
        }
    }
}
