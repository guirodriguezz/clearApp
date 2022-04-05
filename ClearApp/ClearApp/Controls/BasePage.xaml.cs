using Acr.UserDialogs;
using ClearApp.Helpers;
using ClearApp.Views.OpenArea;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClearApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : ContentPage
    {
        #region BindablePropertys
        public static readonly BindableProperty BodyProperty = BindableProperty.Create(nameof(Body), typeof(View), typeof(BasePage), null);
        public static readonly BindableProperty BackButtonProperty = BindableProperty.Create(nameof(BackButton), typeof(bool), typeof(BasePage), true);
        #endregion

        #region Properties
        public View Body
        {
            get { return (View)GetValue(BodyProperty); }
            set { SetValue(BodyProperty, value); }
        }

        public bool BackButton
        {
            get { return (bool)GetValue(BackButtonProperty); }
            set { SetValue(BackButtonProperty, value); }
        }
        #endregion

        public BasePage()
        {
            InitializeComponent();
        }

        #region PropertysChanged
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(Body))
            {
                basePageContent.Children.Add(Body);
            }

            if (propertyName == nameof(BackButton))
            {
                backButton.IsVisible = BackButton;
            }
        }
        #endregion

        #region Methods
        private async void Logout(object sender, System.EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Carregando tela");

            await Task.Delay(TimeSpan.FromSeconds(1));

            SharedHelper.RemoveLogged();
            Application.Current.MainPage = new LoginPage();

            UserDialogs.Instance.HideLoading();
        }

        private async void Voltar(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopAsync(false);
        }
        #endregion
    }
}