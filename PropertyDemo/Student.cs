using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PropertyDemo
{
    public class Student:DependencyObject
    {
        //生成几个基本依赖属性


        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register(nameof(Age), typeof(int), typeof(Student), new PropertyMetadata(0));



        public int Name
        {
            get { return (int)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register(nameof(Name), typeof(int), typeof(Student), new PropertyMetadata(0));




        public int Sex
        {
            get { return (int)GetValue(SexProperty); }
            set { SetValue(SexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Sex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SexProperty =
            DependencyProperty.Register(nameof(Sex), typeof(int), typeof(Student), new PropertyMetadata(0));


    }
}
