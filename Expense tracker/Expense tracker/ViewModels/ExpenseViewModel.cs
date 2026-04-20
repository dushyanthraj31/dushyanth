using System.Collections.ObjectModel;
using ExpenseTracker.Models;

namespace ExpenseTracker.ViewModels;

public class ExpenseViewModel
{
    public ObservableCollection<Expense> Expenses { get; set; }
        = new ObservableCollection<Expense>();

    public void AddExpense(Expense expense)
    {
        Expenses.Add(expense);
    }
}