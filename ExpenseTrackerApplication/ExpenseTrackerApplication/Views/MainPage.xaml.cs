namespace ExpenseTrackerApplication.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.ExpenseViewModel();
    }
}