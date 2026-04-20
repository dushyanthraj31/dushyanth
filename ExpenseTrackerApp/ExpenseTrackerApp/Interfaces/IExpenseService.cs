using System;
using System.Collections.Generic;
using System.Text;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Interfaces
{
    public interface IExpenseService
    {
        List<Category> GetAllCategories();
        List<Expense> GetAllExpenses();
        void AddCategory(Category category);
        void AddExpense(Expense expense);

    }
}
