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
    /// ValidateDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ValidateDemo : Window
    {
        public ValidateDemo()
        {
            InitializeComponent();
            InitDataBinding();
        }

        private void InitDataBinding()
        {
            Binding binding=new Binding("Value")
            {
                Source = this.SliderControl,
                //UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                //校验通知开关
                NotifyOnValidationError = true
            };
            binding.ValidationRules.Add(new ValidationRuleBySlider() { ValidatesOnTargetUpdated=true});
            this.SliderValue.SetBinding(TextBox.TextProperty, binding);
            this.SliderValue.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(ValidationErrorMethod));
        }

        private void ValidationErrorMethod(object sender, RoutedEventArgs e)
        {
            if (e is ValidationErrorEventArgs vea)
            {
                if (vea.Action == ValidationErrorEventAction.Added)
                {
                    this.SliderValue.ToolTip = vea.Error?.ErrorContent?.ToString();
                }
                else if (vea.Action == ValidationErrorEventAction.Removed)
                {
                    // 如果还有其他错误，显示第一个错误，否则清除提示
                    var errors = Validation.GetErrors(this.SliderValue);
                    if (errors != null && errors.Count > 0)
                        this.SliderValue.ToolTip = errors[0].ErrorContent?.ToString();
                    else
                        this.SliderValue.ToolTip = null;
                }
            }
           
        }
    }
}
