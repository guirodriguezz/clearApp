using ClearApp.Models.Orders;
using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ClearApp.Services.Interfaces
{
    public interface IEndPoints
    {
        [Get("/orders")]
        Task<ApiResponse<ObservableCollection<OrdersModel>>> GetOrdersList();
    }
}
