using Acr.UserDialogs;
using ClearApp.Helpers;
using ClearApp.Models.Orders;
using ClearApp.Services;
using ClearApp.Views.Orders;
using MvvmHelpers;
using Newtonsoft.Json;
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
        public ICommand OrdersDetailsCommand { get; set; }
        #endregion

        #region Construtor
        public OrdersListViewModel()
        {
            _ = LoadOrdersList();
            RefreshCommand = new Command(async () => await Refresh());
            OrdersDetailsCommand = new Command<OrdersModel>(OrdersDetails);
        }
        #endregion

        #region Methods
        private async Task LoadOrdersList()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Carregando tela");

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
            if (await IsOnlineHelper.Check())
            {
                var response = await ClearServices.GetOrdersList();
                OrdersList = response.IsSuccessStatusCode ? response.Content : null;

                var serialize = JsonConvert.SerializeObject(OrdersList);
                SharedHelper.OrdersListCached = Task.FromResult(serialize);
            }
            else
            {
                string containsOrdersCached = await SharedHelper.OrdersListCached;

                if (!string.IsNullOrEmpty(containsOrdersCached))
                {
                    var orders = await SharedHelper.OrdersListCached;
                    OrdersList = JsonConvert.DeserializeObject<ObservableCollection<OrdersModel>>(orders);
                }
                else
                {
                    OrdersList = null;
                }              
            }     
        }

        private async Task Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            await GetOrderAsync();
            IsRefreshing = false;
        }

        private async void OrdersDetails(OrdersModel orders)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new OrdersDetailsPage(orders), false);
        }
        #endregion
    }
}
