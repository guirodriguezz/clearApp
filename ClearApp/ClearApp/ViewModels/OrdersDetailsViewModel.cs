using Acr.UserDialogs;
using ClearApp.Models.Orders;
using ClearApp.Views.Orders;
using MvvmHelpers;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClearApp.ViewModels
{

    public class OrdersDetailsViewModel : BaseViewModel
    {
        #region Variables
        private int quantity;
        #endregion

        #region Properties
        private OrdersModel _orderItem;
        public OrdersModel OrderItem
        {
            get => _orderItem;
            set => SetProperty(ref _orderItem, value);
        }

        private int _quantityOrder = 1;
        public int QuantityOrder
        {
            get => _quantityOrder;
            set => SetProperty(ref _quantityOrder, value);
        }

        private decimal _priceOrder;
        public decimal PriceOrder
        {
            get => _priceOrder;
            set => SetProperty(ref _priceOrder, value);
        }

        private decimal _totalOrder;
        public decimal TotalOrder
        {
            get => _totalOrder;
            set => SetProperty(ref _totalOrder, value);
        }

        private Color _subColor = Color.Gray;
        public Color SubColor
        {
            get => _subColor;
            set => SetProperty(ref _subColor, value);
        }

        private Color _addColor = Color.White;
        public Color AddColor
        {
            get => _addColor;
            set => SetProperty(ref _addColor, value);
        }
        #endregion

        #region Commands
        public ICommand SubtractQtCommand { get; set; }
        public ICommand AddQtCommand { get; set; }
        public ICommand FinishedCommand { get; set; }
        public ICommand UnfocusedCommand { get; set; }
        #endregion

        #region Construtor
        public OrdersDetailsViewModel(OrdersModel order)
        {
            OrderItem = order;
            PriceOrder = OrderItem.PriceOrder;
            TotalOrder = order.PriceOrder - OrderItem.Tax;
            quantity = int.Parse(OrderItem.Quantity);

            SubtractQtCommand = new Command(SubtractQt);
            AddQtCommand = new Command(AddQt);
            FinishedCommand = new Command(Finished);
            UnfocusedCommand = new Command(Unfocused);
        }
        #endregion

        #region Methods
        private void SubtractQt()
        {
            if (QuantityOrder > 1)
            {
                AddColor = Color.White;
                QuantityOrder -= 1;
                CalcOrder();
            }
            else
            {
                SubColor = Color.Gray;
            }

        }

        private void AddQt()
        {
            if (QuantityOrder < quantity)
            {
                SubColor = Color.White;
                QuantityOrder += 1;
                CalcOrder();
            }
            else
            {
                AddColor = Color.Gray;
            }
        }

        private void CalcOrder()
        {
            PriceOrder = OrderItem.PriceOrder * QuantityOrder;
            TotalOrder = PriceOrder - OrderItem.Tax;
        }

        private void Unfocused()
        {
            bool zeroQuantity = QuantityOrder == 0;
            bool lessQuantity = QuantityOrder > quantity;

            QuantityOrder = zeroQuantity ? 1 : QuantityOrder;
            SubColor = zeroQuantity ? Color.Gray : Color.White;

            QuantityOrder = lessQuantity ? quantity : QuantityOrder;
            AddColor = lessQuantity ? Color.Gray : Color.White;

            CalcOrder();
        }

        private async void Finished()
        {
            UserDialogs.Instance.ShowLoading("Carregando tela");
            await Task.Delay(TimeSpan.FromSeconds(1));

            Application.Current.MainPage = new OrdersSaleFinished();

            UserDialogs.Instance.HideLoading();
        }
        #endregion
    }
}
