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
            windowType = "Basic";
            Show(windowType);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            windowType = "Advanced";
            Show(windowType);     
        }                                   

        public void Show(String windowType)
        {
            // Create an instance of the basic program.
            if (windowType == "Basic")
            {
                MainWindow basic = new MainWindow();
                basic.Version.Content = basic.Version.Content + windowType;
                basic.Message1.Content = "25x25 or 50x50";
                basic.Message2.Content = "Recommended";
                this.Close();
                basic.Show();
            }

            // Create an instance of the advanced program.
            if (windowType == "Advanced")
            {
                MainWindow adv = new MainWindow();
                adv.Version.Content = adv.Version.Content + windowType;
                adv.Message1.Foreground = Brushes.Black;
                adv.Message2.Foreground = Brushes.Black;
                adv.Message1.Content = "Remember, 2 to 1";
                adv.Message2.Content = "ratios work best...";
                this.Close();
                adv.Show();
            }                     
        }
    }
}
