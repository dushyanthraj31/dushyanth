using loginpagemvvm.views;
using loginpagemvvm.viewmodels;

namespace loginpagemvvm.views;

public partial class StudentMarklistPage : ContentPage
{
	public StudentMarklistPage()
	{
		InitializeComponent();
		BindingContext = new studentviewmodel();
    }
}