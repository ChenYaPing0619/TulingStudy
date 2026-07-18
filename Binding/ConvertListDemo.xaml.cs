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
    /// ConvertListDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ConvertListDemo : Window
    {
        public ConvertListDemo()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            //初始化列表数据
            List<UserInfo> users = new List<UserInfo>()
            {
                new UserInfo() { Name = "Alice", Score = "85", Icon = UserInfo.UserIcons.Bilibili },
                new UserInfo() { Name = "Bob", Score = "92", Icon = UserInfo.UserIcons.WeChat },
                new UserInfo() { Name = "Charlie", Score = "78", Icon = UserInfo.UserIcons.Weibo }
            };  
            this.UserListBox.ItemsSource = users;
            
        }
    }
}
