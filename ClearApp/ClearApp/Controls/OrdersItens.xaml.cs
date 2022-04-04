using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClearApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersItens : StackLayout
    {
        #region BindablePropertys
        public static readonly BindableProperty DateProperty = BindableProperty.Create(nameof(Date), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty LogoProperty = BindableProperty.Create(nameof(Logo), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty SymbolProperty = BindableProperty.Create(nameof(Symbol), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty QuantityProperty = BindableProperty.Create(nameof(Quantity), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty ModuleTriggerProperty = BindableProperty.Create(nameof(ModuleTrigger), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty StatusProperty = BindableProperty.Create(nameof(Status), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty TypeProperty = BindableProperty.Create(nameof(Type), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty SideTriggerProperty = BindableProperty.Create(nameof(SideTrigger), typeof(string), typeof(OrdersItens), null, BindingMode.TwoWay, null);
        #endregion

        #region Properties
        public string Date
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        public string Logo
        {
            get { return (string)GetValue(LogoProperty); }
            set { SetValue(LogoProperty, value); }
        }

        public string Symbol
        {
            get { return (string)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public string Quantity
        {
            get { return (string)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }
        
        public string ModuleTrigger
        {
            get { return (string)GetValue(ModuleTriggerProperty); }
            set { SetValue(ModuleTriggerProperty, value); }
        }
        
        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }

        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        public string SideTrigger
        {
            get { return (string)GetValue(SideTriggerProperty); }
            set { SetValue(SideTriggerProperty, value); }
        }
        #endregion

        public OrdersItens()
        {
            InitializeComponent();
        }
    }
}