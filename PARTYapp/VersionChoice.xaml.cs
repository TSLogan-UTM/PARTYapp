using System;
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

        // Create variable to determine window type.
        String windowType = "None";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            windowType = "basic";
            Show(windowType);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            windowType = "advanced";
            Show(windowType);     
        }                                   

        public void Show(String windowType)
        {
            // Create an instance of the basic program.
            if (windowType == "basic")
            {
                MainWindow basic = new MainWindow();
                basic.Version.Content = basic.Version.Content + windowType;
                this.Close();
                basic.Show();
            }

            // Create an instance of the advanced program.
            if (windowType == "advanced")
            {
                MainWindow adv = new MainWindow();
                adv.Version.Content = adv.Version.Content + windowType;
                this.Close();
                adv.Show();
            }                     
        }
    }
}
