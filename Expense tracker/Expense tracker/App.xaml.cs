using Expense_tracker;
using ExpenseTracker.ViewModels;

namespace ExpenseTracker;

public partial class App : Application
{
    public static ExpenseViewModel ExpenseVM { get; private set; }
    public static CategoryViewModel CategoryVM { get; private set; }

    public App()
    {
        InitializeComponent();

        ExpenseVM = new ExpenseViewModel();
        CategoryVM = new CategoryViewModel();

        MainPage = new NavigationPage(new MainPage());
    }
}