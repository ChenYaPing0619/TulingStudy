using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace TulingGongkong.uc
{
    public class TulingButton:Button
    {
        public Type SubWindow { get; set; }

        protected override void OnClick()
        {
            base.OnClick();
            //通过反射创建子窗口实例并显示
           var window = Activator.CreateInstance(SubWindow) as System.Windows.Window;
            window?.Show();
        }
    }
}
