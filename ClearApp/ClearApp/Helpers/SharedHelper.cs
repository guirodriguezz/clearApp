using Newtonsoft.Json;
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

        #region Config
        static T Deserialize<T>(string serializedObject) => JsonConvert.DeserializeObject<T>(serializedObject);

        static string Serialize<T>(T objectToSerialize) => JsonConvert.SerializeObject(objectToSerialize);
        #endregion
    }
}
