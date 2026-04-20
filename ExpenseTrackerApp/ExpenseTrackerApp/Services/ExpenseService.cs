using System;
using System.Collections.Generic;
using System.Text;
using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Services
{
    public class ExpenseService : IExpenseService
    {
        private List<Category> categories = new()
        {
            new Category { Name = "Food", Icon = "🍔" },
            new Category { Name = "Transport", Icon = "🚌" }
        };

        private List<Expense> expenses = new();

        public List<Category> GetAllCategories() => categories;
        public List<Expense> GetAllExpenses() => expenses;

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }
    }
}
