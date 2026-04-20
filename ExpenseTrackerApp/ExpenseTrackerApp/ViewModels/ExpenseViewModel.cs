using System.Collections.ObjectModel;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.ViewModels;

public class ExpensesViewModel
{
    public ObservableCollection<Expense> Expenses { get; set; }

    public ExpensesViewModel()
    {
        Expenses = new ObservableCollection<Expense>();
    }

    public void AddExpense(Expense expense)
    {
        Expenses.Add(expense);
    }
}