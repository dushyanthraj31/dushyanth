namespace login.pages;

public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }

    public async void SampleAlert(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Login", "Login Button is Clicked", "Ok");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Frame_SizeChanged(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}