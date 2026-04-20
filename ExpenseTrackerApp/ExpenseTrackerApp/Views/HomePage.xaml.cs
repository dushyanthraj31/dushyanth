using ExpenseTrackerApp.ViewModels;
using ExpenseTrackerApp.Services;

namespace ExpenseTrackerApp.Views;

public partial class HomePage : ContentPage
{
        public HomePage() : this(new HomeViewModel(new ExpenseService()))
        {
        }

        public HomePage(HomeViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }

        private async void OnCategories(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }

        private async void OnExpenses(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }    
}