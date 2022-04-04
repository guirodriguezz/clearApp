using Acr.UserDialogs;
using ClearApp.Models.Orders;
using ClearApp.Services;
using MvvmHelpers;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClearApp.ViewModels
{

    public class OrdersListViewModel : BaseViewModel
    {
        #region Properties
        private ObservableCollection<OrdersModel> _ordersList;
        public ObservableCollection<OrdersModel> OrdersList
        {
            get => _ordersList;
            set => SetProperty(ref _ordersList, value);
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value);
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand { get; set; }
        #endregion

        #region Construtor
        public OrdersListViewModel()
        {
            _ = LoadOrdersList();
            RefreshCommand = new Command(async () => await Refresh());
        }
        #endregion

        #region Methods
        private async Task LoadOrdersList()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Aguarde...");

                await GetOrderAsync();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                await Application.Current.MainPage.DisplayAlert("ATENÇÃO", "Ocorreu um erro ao processar sua solicitação", "Ok");
            }
            finally
            {
                UserDialogs.Instance.HideLoading();
            }
        }

        private async Task GetOrderAsync()
        {
            var response = await ClearServices.GetOrdersList();
            OrdersList = response.IsSuccessStatusCode ? response.Content : null;
        }

        private async Task Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            await GetOrderAsync();
            IsRefreshing = false;
        }
        #endregion
    }
}
