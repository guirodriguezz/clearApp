using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClearApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionClear : CollectionView
    {
        #region BindablePropertys
        public static readonly BindableProperty OrdersEmptyProperty = BindableProperty.Create(nameof(OrdersEmpty), typeof(bool), typeof(CollectionClear), null, BindingMode.TwoWay, propertyChanged: EmptyOrdersPropertyChanged);
        #endregion

        #region Properties
        public bool OrdersEmpty
        {
            get { return (bool)GetValue(OrdersEmptyProperty); }
            set { SetValue(OrdersEmptyProperty, value); }
        }
        #endregion

        public CollectionClear()
        {
            InitializeComponent();
        }

        #region PropertysChanged
        private static void EmptyOrdersPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CollectionClear)bindable;
            control.emptyView.IsVisible = (bool)newValue;
        }
        #endregion
    }
}