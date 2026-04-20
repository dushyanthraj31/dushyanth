using System.Collections.ObjectModel;
using System.Windows.Input;
using ExpenseTrackerApplication.Models;
using ExpenseTrackerApplication.Services;

namespace ExpenseTrackerApplication.ViewModels;

public class ExpenseViewModel
{
    private readonly ExpenseService _expenseService;

    public ObservableCollection<Expense> Expenses => _expenseService.Expenses;

    public ICommand AddExpenseCommand { get; }

    public ExpenseViewModel()
    {
        _expenseService = new ExpenseService();
        AddExpenseCommand = new Command(AddExpense);
    }

    private void AddExpense()
    {
        _expenseService.AddExpense(new Expense
        {
            Title = "Sample",
            Amount = 100,
            Category = "Food",
            Date = DateTime.Now
        });
    }
}