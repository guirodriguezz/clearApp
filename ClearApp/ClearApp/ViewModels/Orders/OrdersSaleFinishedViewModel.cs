using ClearApp.Views.Orders;
using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClearApp.ViewModels.Orders
{

    public class OrdersSaleFinishedViewModel : BaseViewModel
    {
        #region Commands
        public ICommand BackOrdersListCommand { get; set; }
        #endregion

        #region Construtor
        public OrdersSaleFinishedViewModel()
        {
            BackOrdersListCommand = new Command(BackOrdersList);
        }
        #endregion

        #region Methods
        public void BackOrdersList()
        {
            Application.Current.MainPage = new NavigationPage(new OrdersListPage());
        }
        #endregion
    }
}
