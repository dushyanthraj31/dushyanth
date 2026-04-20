using System;
using ExpenseTrackerApplication.Models;
using System.Collections.ObjectModel;


namespace ExpenseTrackerApplication.Services
{
    public class ExpenseService
    {
        public ObservableCollection<Expense> Expenses { get; private set; } = new();
        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }
        public void RemoveExpense(Expense expense)
        {
            Expenses.Remove(expense);
        }
    }
}
