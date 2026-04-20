using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Views;

public partial class CategoriesPage : ContentPage
{
    public CategoriesPage()
    {
        InitializeComponent();
        BindingContext = App.CategoriesVM;
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(CategoryEntry.Text))
        {
            App.CategoriesVM.AddCategory(CategoryEntry.Text);
            CategoryEntry.Text = "";
        }
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var category = button?.BindingContext as Category;

        if (category != null)
        {
            App.CategoriesVM.DeleteCategory(category);
        }
    }
}