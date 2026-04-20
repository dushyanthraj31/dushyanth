using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Views;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage()
    {
        InitializeComponent();

        BindingContext = App.ExpensesVM;

        // Load categories into picker
        CategoryPicker.ItemsSource = App.CategoriesVM.Categories;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        decimal amount = 0;
        decimal.TryParse(AmountEntry.Text, out amount);

        var expense = new Expense
        {
            Title = TitleEntry.Text,
            Amount = amount,
            Date = DatePicker.Date,
            Category = CategoryPicker.SelectedItem as Category
        };

        App.ExpensesVM.AddExpense(expense);

        await Navigation.PopAsync();
    }
}