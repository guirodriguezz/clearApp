using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClearApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryClearOrder : ContentView
    {
        #region BindablePropertys
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(EntryClearOrder), string.Empty, BindingMode.TwoWay, null);
        public static readonly BindableProperty SubtractCommandProperty = BindableProperty.Create(nameof(SubtractCommand), typeof(ICommand), typeof(EntryClearOrder), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty AddCommandProperty = BindableProperty.Create(nameof(AddCommand), typeof(ICommand), typeof(EntryClearOrder), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty SubtractColorProperty = BindableProperty.Create(nameof(SubtractColor), typeof(Color), typeof(EntryClearOrder), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty AddColorProperty = BindableProperty.Create(nameof(AddColor), typeof(Color), typeof(EntryClearOrder), null, BindingMode.TwoWay, null);
        public static readonly BindableProperty UnfocusedCommandProperty = BindableProperty.Create(nameof(UnfocusedCommand), typeof(ICommand), typeof(EntryClearOrder), null, BindingMode.TwoWay, null);
        #endregion

        #region Properties
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ICommand SubtractCommand
        {
            get { return (ICommand)GetValue(SubtractCommandProperty); }
            set { SetValue(SubtractCommandProperty, value); }
        }

        public ICommand AddCommand
        {
            get { return (ICommand)GetValue(AddCommandProperty); }
            set { SetValue(AddCommandProperty, value); }
        }

        public Color SubtractColor
        {
            get { return (Color)GetValue(SubtractColorProperty); }
            set { SetValue(SubtractColorProperty, value); }
        }
        
        public Color AddColor
        {
            get { return (Color)GetValue(AddColorProperty); }
            set { SetValue(AddColorProperty, value); }
        }
        #endregion

        public EntryClearOrder()
        {
            InitializeComponent();
        }

        #region Methods
        private void Subtract_Tapped(object sender, System.EventArgs e)
        {
            if (SubtractCommand != null)
            {
                SubtractCommand.Execute(null);
            }
        }

        public ICommand UnfocusedCommand
        {
            get { return (ICommand)GetValue(UnfocusedCommandProperty); }
            set { SetValue(UnfocusedCommandProperty, value); }
        }

        private void Add_Tapped(object sender, System.EventArgs e)
        {
            if (AddCommand != null)
            {
                AddCommand.Execute(null);
            }
        }
        #endregion

        private void EntryWithoutLine_Unfocused(object sender, FocusEventArgs e)
        {
            if (UnfocusedCommand != null)
            {
                UnfocusedCommand.Execute(null);
            }
        }
    }
}