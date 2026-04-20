using ExpenseTracker.Models;

namespace ExpenseTracker.Views;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage()
    {
        InitializeComponent();
        CategoryPicker.ItemsSource = App.CategoryVM.Categories;
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

        App.ExpenseVM.AddExpense(expense);

        await Navigation.PopAsync();
    }
}