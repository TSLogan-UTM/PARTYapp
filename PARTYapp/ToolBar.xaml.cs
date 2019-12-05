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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ToolBar : Window
    {
        
        byte r = 0;
        byte g = 0;
        byte b = 0;

        int Splash_Select = 0;
        

        public ToolBar()
        {
            InitializeComponent();
   
            // Set the window to open 25 pixels from the left of the user's screen.
            // See WindowStartupLocation "Top" in ToolBar.xaml for window indention from top of user's screen.
            double toolBarOffset = 25;
            this.Left = SystemParameters.PrimaryScreenWidth - (SystemParameters.PrimaryScreenWidth - (toolBarOffset));
        }

        private void Title_Bar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Declare this for the rectangle used as the title bar to allow the window to be moved...
            this.DragMove();
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            r = Convert.ToByte(e.NewValue);
            ColorBox.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            g = Convert.ToByte(e.NewValue);
            ColorBox.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            b = Convert.ToByte(e.NewValue);
            ColorBox.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Button btn2 = btn;
            btn2.Background = ColorBox.Background;

            if (Splash_Select == 1)
            {
                PARTYapp.WorkGrid.AppWindow.Splash(btn2, btn);
            }
            else
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            PARTYapp.WorkGrid.AppWindow.clear();
        }

        private void SaveTool_Click(object sender, RoutedEventArgs e)
        {
            SaveFile app = new SaveFile();
            app.Show();
        }

        private void LoadTool_Click(object sender, RoutedEventArgs e)
        {
            LoadFile app = new LoadFile();
            app.Show();
        }

        private void SplashTool_Click(object sender, RoutedEventArgs e)
        {
            if(Splash_Select == 0)
            {
                Splash_Select = 1;
                MessageBox.Show("Splash mode Selected", "PARTY FOUL");
            }
            else
            {
                Splash_Select = 0;
                
            }
        }

        private void PixelTool_Click(object sender, RoutedEventArgs e)
        {
            Splash_Select = 0;
            MessageBox.Show("Pixel mode Selected", "PARTY FOUL");
        }
    }
}
