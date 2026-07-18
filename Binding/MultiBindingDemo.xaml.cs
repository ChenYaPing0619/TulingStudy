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

namespace BindingDemo
{
    /// <summary>
    /// MultiBindingDemo.xaml 的交互逻辑
    /// </summary>
    public partial class MultiBindingDemo : Window
    {
        public MultiBindingDemo()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            var mb = new MultiBinding();
            mb.Bindings.Add(new Binding("Text") { Source = this.Sex_B });
            mb.Bindings.Add(new Binding("Text") { Source = this.Age_B });
            mb.Converter = new MultiBindingConvert();
            mb.NotifyOnSourceUpdated = true;
            this.AgeResult.SetBinding(Label.ContentProperty, mb);

        }
    }
}
