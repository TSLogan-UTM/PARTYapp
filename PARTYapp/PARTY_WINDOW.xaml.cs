using System;
using System.Collections.Generic;
using System.Drawing;
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
using Brushes = System.Windows.Media.Brushes;


namespace PARTYapp
{
    
    /// <summary>
    /// Interaction logic for PARTY_WINDOW.xaml
    /// </summary>
    public partial class PARTY_WINDOW : Window
    {
        public int Colour = 0;
        public PARTY_WINDOW()
        {

            InitializeComponent();

        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(Colour == 0)
            {
                btn.Background = Brushes.Black;
            }
            if(Colour == 1)
            {
                btn.Background = Brushes.Red;
            }
            if(Colour == 2)
            {
                btn.Background = Brushes.LimeGreen;
            }
            if(Colour == 3)
            {
                btn.Background = Brushes.Blue;
            }
            if(Colour == 4)
            {
                btn.Background = Brushes.White;
            }
            if(Colour == 5)
            {
                btn.Background = Brushes.Cyan;
            }
            if(Colour == 6)
            {
                btn.Background = Brushes.Purple;
            }
            if(Colour == 7)
            {
                btn.Background = Brushes.Yellow;
            }
            if(Colour == 8)
            {
                btn.Background = Brushes.SaddleBrown;
            }
            if(Colour == 9)
            {
                btn.Background = Brushes.Gray;
            }
        }

        private void WB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            WB.IsReadOnly = true;
        }

        private void HB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            HB.IsReadOnly = true;

            
        }


        private void CtrlAltYeet_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you Sure?", "PARTY FOUL", MessageBoxButton.YesNo);

            if(result == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
            else
            {
                return;
            }

            
        }

        private void BLACK_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 0;
        }

        private void RED_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 1;
        }

        private void GREEN_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 2;
        }

        private void BLUE_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 3;
        }

        private void WHITE_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 4;
        }

        private void CYAN_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 5;
        }

        private void PURPLE_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 6;
        }

        private void YELLOW_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 7;
        }

        private void BROWN_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            Colour = 8;
        }

        private void GRAY_BUTTONS_Click(object sender, RoutedEventArgs e)
        {
            Colour = 9;
        }
    }
}
