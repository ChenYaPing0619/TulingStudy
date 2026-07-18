using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BindingDemo
{
    class ValidationRuleBySlider : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return new ValidationResult(false, "Invalid value.");
            }

            double doubleValue;
            // 如果已经是 double 类型，直接使用
            if (value is double d)
            {
                doubleValue = d;
            }
            else
            {
                // 尝试将 value 转为字符串并解析，避免抛出异常
                var s = Convert.ToString(value, cultureInfo);
                if (!double.TryParse(s, System.Globalization.NumberStyles.Any, cultureInfo, out doubleValue))
                {
                    return new ValidationResult(false, "Invalid value type.");
                }
            }

            if (doubleValue < 18 || doubleValue > 100)
            {
                return new ValidationResult(false, "您已超出年龄限制");
            }

            return ValidationResult.ValidResult;
        }
    }
}
