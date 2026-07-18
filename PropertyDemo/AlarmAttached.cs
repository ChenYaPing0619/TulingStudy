using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PropertyDemo
{
    public static class AlarmAttached
    {
        public static readonly DependencyProperty IsAlarmProperty =
            DependencyProperty.RegisterAttached(
                "IsAlarm",
                typeof(bool),
                typeof(AlarmAttached),
                new PropertyMetadata(false, OnIsAlarmChanged));

        public static bool GetIsAlarm(DependencyObject obj) =>
            (bool)obj.GetValue(IsAlarmProperty);

        public static void SetIsAlarm(DependencyObject obj, bool value) =>
            obj.SetValue(IsAlarmProperty, value);

        private static void OnIsAlarmChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Control c)
            {
                bool isAlarm = (bool)e.NewValue;
                c.Background = isAlarm ? Brushes.IndianRed : Brushes.White;
                c.Foreground = isAlarm ? Brushes.White : Brushes.Black;
            }
        }
    }
}