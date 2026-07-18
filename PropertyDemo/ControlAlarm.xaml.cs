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

namespace PropertyDemo
{
    /// <summary>
    /// ControlAlarm.xaml 的交互逻辑
    /// </summary>
    public partial class ControlAlarm : Window
    {
        public ControlAlarm()
        {
            InitializeComponent();
        }

        private void SetAlarmButton_Click(object sender, RoutedEventArgs e)
        {
            AlarmAttached.SetIsAlarm(this.AlarmText1, true);
            AlarmAttached.SetIsAlarm(this.AlarmText2, true);
        }

        private void ClearAlarmButton_Click(object sender, RoutedEventArgs e)
        {
            AlarmAttached.SetIsAlarm(this.AlarmText1, false);
            AlarmAttached.SetIsAlarm(this.AlarmText2, false);
        }
    }
}
