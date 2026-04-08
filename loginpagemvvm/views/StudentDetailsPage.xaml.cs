// loginpagemvvm/views/StudentDetailsPage.xaml.cs
using loginpagemvvm.viewmodels;

namespace loginpagemvvm.views;

public partial class StudentDetailsPage : ContentPage
{
    public StudentDetailsPage()
    {
        InitializeComponent();
        BindingContext = new studentviewmodel();
    }
}