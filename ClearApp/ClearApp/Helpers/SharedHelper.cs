using ClearApp.Models.Orders;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ClearApp.Helpers
{
    public static class SharedHelper
    {
        public static string LoggedUser
        {
            get
            {
                string savedList = Deserialize<string>(Preferences.Get(nameof(LoggedUser), null));
                return savedList ?? string.Empty;
            }
            set
            {
                string serializedList = Serialize(value);
                Preferences.Set(nameof(LoggedUser), serializedList);
            }
        }

        public static void RemoveLogged() => Preferences.Remove(nameof(LoggedUser));
        public static bool ContainsLoggedUser() => Preferences.ContainsKey(nameof(LoggedUser));

        public static Task<string> OrdersListCached
        {
            get
            {
                var savedList = SecureStorage.GetAsync(nameof(OrdersListCached));
                return savedList;
            }
            set
            {
                SecureStorage.SetAsync(nameof(OrdersListCached), value.Result);
            }
        }

        public static void RemoveOrdersCached() => Preferences.Remove(nameof(OrdersListCached));

        #region Config
        static T Deserialize<T>(string serializedObject) => JsonConvert.DeserializeObject<T>(serializedObject);

        static string Serialize<T>(T objectToSerialize) => JsonConvert.SerializeObject(objectToSerialize);
        #endregion
    }
}
