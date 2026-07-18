using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace CommunityToolkitDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            CultureInfo.CurrentCulture = new CultureInfo("zh-CN");
            CultureInfo.CurrentUICulture = new CultureInfo("zh-CN");
        }
    }

}
