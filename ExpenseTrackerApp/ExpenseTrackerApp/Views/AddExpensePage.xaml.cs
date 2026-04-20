using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Views;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage() 
    {
        InitializeComponent();

        CategoryPicker.ItemsSource = App.CategoriesVM.Categories;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (!decimal.TryParse(AmountEntry.Text, out decimal amount))
        {
            await DisplayAlert("Error", "Invalid amount", "OK");
            return;
        }

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