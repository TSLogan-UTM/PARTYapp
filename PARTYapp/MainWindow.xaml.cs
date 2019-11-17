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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PARTYapp
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {

            PARTY_WINDOW app = new PARTY_WINDOW();

            app.Show();
            this.Close();
            app.HB.Text = HeightBox.Text;
            app.WB.Text = WidthBox.Text;
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightSlider.Value = Math.Round(HeightSlider.Value, 0);
            HeightBox.Text = Convert.ToString(HeightSlider.Value);
        }

        private void HeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            HeightSlider.IsSnapToTickEnabled = true;
            HeightSlider.TickPlacement = System.Windows.Controls.Primitives.TickPlacement.TopLeft;
            HeightSlider.TickFrequency = 25;
            HeightBox.IsReadOnly = true;
            HeightBox.Text = Convert.ToString(HeightSlider.Value);
            
        }

        private void WidthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WidthSlider.Value = Math.Round(WidthSlider.Value, 0);
            WidthBox.Text = Convert.ToString(WidthSlider.Value);
        }


        private void WidthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WidthSlider.IsSnapToTickEnabled = true;
            WidthSlider.TickPlacement = System.Windows.Controls.Primitives.TickPlacement.TopLeft;
            WidthSlider.TickFrequency = 25;
            WidthBox.IsReadOnly = true;
            WidthBox.Text = Convert.ToString(WidthSlider.Value);
        }

        public MainWindow()
        {
            
            InitializeComponent();

            
        }
    }
}
