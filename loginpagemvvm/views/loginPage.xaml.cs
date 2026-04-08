using loginpagemvvm.views;

namespace loginpagemvvm.views;

public partial class loginPage : ContentPage
{
	public loginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	
		{
			await Navigation.PushAsync(new MainTabbedPage());
		}
		
	
}