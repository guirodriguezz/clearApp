using ClearApp.Models.Orders;
using ClearApp.Services.Interfaces;
using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ClearApp.Services
{
    public static class ClearServices
    {
        private static string BaseUrl => "https://6123c2e6124d880017568476.mockapi.io/api/v1/swingtrade";
        private static IEndPoints Endpoint => RestService.For<IEndPoints>(BaseUrl);

        public static async Task<ApiResponse<ObservableCollection<OrdersModel>>> GetOrdersList()
        {
            return await Endpoint.GetOrdersList();
        }
    }
}
