using ClearApp.Helpers;
using ClearApp.Views.OpenArea;
using ClearApp.Views.Orders;
using Xamarin.Forms;

namespace ClearApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            OpenScreen();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected void OpenScreen()
        {
            bool loggedUser = SharedHelper.ContainsLoggedUser();

            if (loggedUser) 
                MainPage = new OrdersListPage();
            else 
                MainPage = new LoginPage();
        }
    }
}
