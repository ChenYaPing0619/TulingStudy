using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BindingDemo
{
    class MultiBindingConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // 第一个参数为性别（只支持 "男"/"女"），第二个参数为年龄（int）
            if (values == null || values.Length < 2)
                return false;

            // 解析性别
            var genderObj = values[0];
            string gender = genderObj?.ToString()?.Trim() ?? string.Empty;

            // 解析年龄
            int age;
            if (values[1] is int ai)
            {
                age = ai;
            }
            else
            {
                if (!int.TryParse(values[1]?.ToString(), out age))
                    return false;
            }

            // 规则：男 >= 22，女 >= 20
            if (gender == "男")
                return age >= 22;
            if (gender == "女")
                return age >= 20;

            // 非法性别返回 false
            return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
