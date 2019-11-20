﻿using System;
using System.Collections.Generic;
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

namespace PARTYapp
{
    /// <summary>
    /// Interaction logic for VersionChoice.xaml
    /// </summary>
    public partial class VersionChoice : Window
    {
        public VersionChoice()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow basic = new MainWindow();
            this.Close();
            basic.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Create an instance of the advanced class and tool bar.
            Advanced advanced = new Advanced();
            ToolBar tools = new ToolBar();
            this.Close();
            advanced.Show();
            tools.Show();       //      <<-------- Could probably implement this inside the advanced window similar to how
        }                       //                 Vincent did the canvas instead.
    }
}
