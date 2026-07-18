using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserInfo userInfo=new UserInfo { Name="Anderson"};
        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            var binding = new Binding("Name");
            binding.Source = this.userInfo;
            binding.Mode = BindingMode.TwoWay;
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            this.UserName.SetBinding(TextBox.TextProperty, binding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DisplayUsername.Text = userInfo.Name;
        }
    }
}