using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ClearApp.Helpers
{
    public static class OpenBrowserHelper
    {
        private static async Task OpenBrowser(Uri uri)
        {
            try
            {
                await Browser.OpenAsync(uri, new BrowserLaunchOptions
                {
                    LaunchMode = BrowserLaunchMode.SystemPreferred,
                    TitleMode = BrowserTitleMode.Show,
                    PreferredToolbarColor = Color.FromHex("#131a20"),
                    PreferredControlColor = Color.Violet
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Application.Current.MainPage.DisplayAlert("ATENÇÃO", "Não foi encontrado um aplicativo pra abrir o link externo", "Ok");
            }
        }

        public static async Task OpenClearConta()
        {
            await OpenBrowser(new Uri("https://cadastro.clear.com.br/desktop/step/1"));
        }
    }
}
