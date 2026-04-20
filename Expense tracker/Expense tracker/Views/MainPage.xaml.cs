namespace ExpenseTracker;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ExpenseList.ItemsSource = App.ExpenseVM.Expenses;
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.AddExpensePage());
    }
}