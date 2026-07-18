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
    /// BindingSourceByList.xaml 的交互逻辑
    /// </summary>
    public partial class BindingSourceByList : Window
    {
        public BindingSourceByList()
        {
            InitializeComponent();
            InitDataBinding();
        }

        private void InitDataBinding()
        {
            // 初始化数据绑定逻辑
            //创建种子数据
            List<UserInfo> userList = new List<UserInfo>
            {
                new UserInfo { Name = "Alice", Score = "85" },
                new UserInfo { Name = "Bob", Score = "90" },
                new UserInfo { Name = "Charlie", Score = "78" }
            };
            this.StudentNameList.ItemsSource= userList;
            this.StudentNameList.SelectedIndex=0;
            //this.StudentNameList.DisplayMemberPath= "Name";
        }
    }
}
