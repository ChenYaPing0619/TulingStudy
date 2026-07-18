using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PropertyDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student student = new Student();
        public MainWindow()
        {
            InitializeComponent();

            student.Age = 18;
            School.SetClass(student, 1);
            int studentclass=School.GetClass(student);

            Binding binding = new Binding("Age");
            binding.Source = student;
            binding.Mode = BindingMode.TwoWay;
            this.TextBoxAge.SetBinding(TextBox.TextProperty, binding);
        }

        private void ButtonSetPlus_Click(object sender, RoutedEventArgs e)
        {
            student.Age++;
        }

        private void ButtonSetMinus_Click(object sender, RoutedEventArgs e)
        {
            student.Age--;
        }
    }
}