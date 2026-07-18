using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PropertyDemo
{
    public class School : DependencyObject
    {


        public static int GetClass(DependencyObject obj)
        {
            return (int)obj.GetValue(ClassProperty);
        }

        public static void SetClass(DependencyObject obj, int value)
        {
            obj.SetValue(ClassProperty, value);
        }

        // Using a DependencyProperty as the backing store for Class.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClassProperty =
            DependencyProperty.RegisterAttached("Class", typeof(int), typeof(School), new PropertyMetadata(0));


    }
}
