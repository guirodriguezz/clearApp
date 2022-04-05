using Plugin.Connectivity;
using System.Threading.Tasks;

namespace ClearApp.Helpers
{
    public static class IsOnlineHelper
    {
        public async static Task<bool> Check()
        {
            try
            {
                var connectivity = CrossConnectivity.Current;
                if (!connectivity.IsConnected)
                    return false;

                var reachable = await connectivity.IsRemoteReachable("google.com.br");

                return reachable;
            }
            catch
            {
                return false;
            }
        }
    }
}
