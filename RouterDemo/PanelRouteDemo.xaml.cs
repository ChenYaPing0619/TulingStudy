using System;
using System.Windows;
using System.Windows.Controls;

namespace RouterDemo
{
    /// <summary>
    /// PanelRouteDemo.xaml 的交互逻辑
    /// </summary>
    public partial class PanelRouteDemo : Window
    {
        public PanelRouteDemo()
        {
            InitializeComponent();

            // 在父容器统一监听一次 Click（不需要给每个按钮都写 Click）
            this.ButtonPanel.AddHandler(Button.ClickEvent, new RoutedEventHandler(OnPanelButtonClick));
        }

        private void OnPanelButtonClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is not Button button)
                return;

            string actionCode = button.Tag?.ToString() ?? string.Empty;
            string actionText = actionCode switch
            {
                "Start" => "下发启动命令",
                "Stop" => "下发停止命令",
                "ResetAlarm" => "执行报警复位",
                "AckAlarm" => "执行报警确认",
                "Manual" => "切换到手动模式",
                "Auto" => "切换到自动模式",
                _ => "未知命令"
            };

            string log = $"{DateTime.Now:HH:mm:ss} | 按钮={button.Content} | 处理={actionText}";
            this.ActionText.Text = $"最近动作：{actionText}";
            this.LogList.Items.Add(log);
        }
    }
}
