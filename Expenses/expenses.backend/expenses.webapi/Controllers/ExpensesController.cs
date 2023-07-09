﻿using Expenses.Core;
using Expenses.Core.DTO;
using Expenses.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Expenses.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesServices expensesServices;

        public ExpensesController(IExpensesServices expensesServices)
        {
            this.expensesServices = expensesServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetExpensesAsync()
        {
            return Ok(await expensesServices.GetExpensesAsync());
        }

        [HttpGet("{id}", Name = "GetExpense")]
        public IActionResult GetExpense(int id)
        {
            return Ok(expensesServices.GetExpense(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateExpense(Expense expense)
        {
            var newExpense = await expensesServices.CreateExpenseAsync(expense);
            return CreatedAtRoute("GetExpense", new { newExpense.Id}, newExpense);
        }

        [HttpDelete]
        public IActionResult DeleteExpense(ExpenseDTO expense)
        {
            expensesServices.DeleteExpense(expense);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditExpense(ExpenseDTO expense)
        {
            var updatedExpense = await expensesServices.EditExpenseAsync(expense);
            return Ok(updatedExpense);
        }
    }
}
