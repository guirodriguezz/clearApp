using ClearApp.Helpers;
using ClearApp.Views.Orders;
using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClearApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Properties
        private bool _loading = false;
        public bool Loading
        {
            get => _loading;
            set => SetProperty(ref _loading, value);
        }
        #endregion

        #region Commands
        public ICommand AbrirContaCommand { get; set; }
        public ICommand GoOrdersListCommand { get; set; }
        #endregion

        #region Construtor
        public LoginViewModel()
        {
            AbrirContaCommand = new Command(async () => await AbrirConta());
            GoOrdersListCommand = new Command(GoOrdersList);
        }
        #endregion

        #region Methods
        public async Task AbrirConta()
        {
            await OpenBrowserHelper.OpenClearConta();
        }

        public void GoOrdersList()
        {
            SharedHelper.LoggedUser = "Logged";

            Application.Current.MainPage = new NavigationPage(new OrdersListPage());
        }
        #endregion
    }
}