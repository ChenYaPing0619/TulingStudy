using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RouterDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // AddHandler：即使事件已被标记为 Handled，也继续接收
            this.RootGrid.AddHandler(
                UIElement.MouseDownEvent,
                new MouseButtonEventHandler(RootGrid_MouseDown_ByAddHandler),
                true);
        }

        // ------------------ 普通订阅（XAML 事件） ------------------
        // 隧道（Preview）
        private void RootGrid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
            => AddLog($"[隧道-普通] Grid PreviewMouseDown, Source={GetSourceName(e.OriginalSource)}");

        private void DemoBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
            => AddLog($"[隧道-普通] Border PreviewMouseDown, Source={GetSourceName(e.OriginalSource)}");

        private void DemoButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
            => AddLog($"[隧道-普通] Button PreviewMouseDown, Source={GetSourceName(e.OriginalSource)}");

        // 冒泡（MouseDown）
        private void DemoButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddLog($"[冒泡-普通] Button MouseDown, Source={GetSourceName(e.OriginalSource)}");
            // 在子控件处拦截，验证普通订阅的父级冒泡是否被阻断
            e.Handled = true;
            AddLog("[拦截] Button 将 e.Handled = true");
        }

        private void DemoBorder_MouseDown(object sender, MouseButtonEventArgs e)
            => AddLog($"[冒泡-普通] Border MouseDown, Source={GetSourceName(e.OriginalSource)}");

        private void RootGrid_MouseDown(object sender, MouseButtonEventArgs e)
            => AddLog($"[冒泡-普通] Grid MouseDown, Source={GetSourceName(e.OriginalSource)}");

        // ------------------ AddHandler 订阅 ------------------
        private void RootGrid_MouseDown_ByAddHandler(object sender, MouseButtonEventArgs e)
            => AddLog($"[冒泡-AddHandler] Grid 收到 MouseDown(handledEventsToo=true), Source={GetSourceName(e.OriginalSource)}, Handled={e.Handled}");

        private void AddLog(string text)
        {
            this.LogList.Items.Add(text);
        }

        private static string GetSourceName(object source)
        {
            if (source is FrameworkElement fe && !string.IsNullOrWhiteSpace(fe.Name))
                return fe.Name;
            return source?.GetType().Name ?? "Unknown";
        }
    }
}
