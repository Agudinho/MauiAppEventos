
using MauiAppEventos.Models;
using MauiAppEventos.Views;
namespace MauiAppEventos
{
    public partial class App : Application
    {
        


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroEventos());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 600;

            return window;
        }
    }
}
