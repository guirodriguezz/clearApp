using ClearApp.Controls;
using ClearApp.Models.Orders;
using ClearApp.ViewModels.Orders;
using Xamarin.Forms.Xaml;

namespace ClearApp.Views.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersDetailsPage : BasePage
    {
        public OrdersDetailsPage(OrdersModel order)
        {
            InitializeComponent();
            OrdersDetailsViewModel viewModel = new OrdersDetailsViewModel(order);
            BindingContext = viewModel;
        }
    }
}