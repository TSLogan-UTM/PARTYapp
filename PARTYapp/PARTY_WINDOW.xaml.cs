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
using Point = System.Windows.Point;


namespace PARTYapp
{
    
    /// <summary>
    /// Interaction logic for PARTY_WINDOW.xaml
    /// </summary>
    public partial class PARTY_WINDOW : Window
    {
        public PARTY_WINDOW()
        {

            

            InitializeComponent();

            GRID_100.ShowGridLines = false;
            GRID_75.ShowGridLines = false;
            //GRID_50.ShowGridLines = false;
            GRID_25.ShowGridLines = false;
            int count = 1;


            int width = 50;
            int height = 50;

            for (int i = 0; i < width - 1; i++)
            {
                for (int j = 0; j < height - 1; j++)
                {
                    Button MyControl1 = new Button();
                    MyControl1.Content = "";
                    MyControl1.Name = "Button" + count.ToString();
                    MyControl1.Background = Brushes.White;
                    if(count%2 > 0)
                    {
                        MyControl1.Background = Brushes.Gray;
                    }

                    Grid.SetColumn(MyControl1, j);
                    Grid.SetRow(MyControl1, i);
                    GRID_50.Children.Add(MyControl1);

                    count++;
                }

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
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


    }
}
