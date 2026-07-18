using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static BindingDemo.UserInfo;
using System.Windows.Media.Imaging;

namespace BindingDemo
{
    public class IconsConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            if (!(value is UserIcons user)) return null;

            string packUri = user switch
            {
                UserIcons.Bilibili => "pack://application:,,,/Images/bilibili.png",
                UserIcons.WeChat => "pack://application:,,,/Images/weixin.png",
                UserIcons.Weibo => "pack://application:,,,/Images/weibo.png",
                _ => null
            };

            if (string.IsNullOrEmpty(packUri)) return null;

            try
            {
                return packUri;

                //return new BitmapImage(new Uri(packUri, UriKind.Absolute));
            }
            catch
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
