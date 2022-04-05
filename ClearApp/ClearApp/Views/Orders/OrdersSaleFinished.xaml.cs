using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClearApp.Views.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersSaleFinished : ContentPage
    {
        public OrdersSaleFinished()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}