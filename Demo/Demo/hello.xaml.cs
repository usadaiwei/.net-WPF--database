﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for hello.xaml
    /// </summary>
    public partial class hello : Window
    {
        String _name;
        String _age;
        public hello(String name, String age)
        {
            InitializeComponent();
            _name = name;
            _age = age;
        }

        private void Window2_Loaded(object sender, RoutedEventArgs e)
        {
            String userName = _name;
            String userAge = _age;
            //String output = "Thank you, " + userName + ", " + userAge + " years old";
            //var label = sender as Label;
            //label.Content = output;
            aa.Content = userName;
            bb.Content = userAge;
            //MessageBox.Show(output);

        }
    }
}
