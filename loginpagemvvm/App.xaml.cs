using loginpagemvvm.views;
using Microsoft.Extensions.DependencyInjection;

namespace loginpagemvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new loginPage()));
        }
    }
}