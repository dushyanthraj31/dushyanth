using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp;

public partial class App : Application
{
    public static ExpensesViewModel ExpensesVM { get; private set; }
    public static CategoriesViewModel CategoriesVM { get; private set; }

    public App()
    {
        InitializeComponent();

        ExpensesVM = new ExpensesViewModel();
        CategoriesVM = new CategoriesViewModel();

        CategoriesVM.AddDefaultCategories();

        MainPage = new NavigationPage(new MainPage());
    }
}