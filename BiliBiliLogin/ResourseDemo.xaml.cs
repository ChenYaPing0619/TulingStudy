using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BiliBiliLogin
{
    /// <summary>
    /// ResourseDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ResourseDemo : Window
    {
        public ResourseDemo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["SolidColorBrushOne"] = new SolidColorBrush(Colors.Green);
            this.Resources["SolidColorBrushThree"] = new SolidColorBrush(Colors.Green);

        }
    }
}
