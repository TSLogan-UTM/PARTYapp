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
        public int Colour = 0;//Global variable to keep track of colour changes
        public int Tool = 0;//not in use yet
        public PARTY_WINDOW()
        {

            InitializeComponent();
            
        }

        public void Button_Click(object sender, EventArgs e) //This is the function that changes the colours of the clicked pixel
        {
            Button btn = sender as Button;

            if (Colour == 0)
            {
                btn.Background = Brushes.Black;
            }
            if (Colour == 1)
            {
                btn.Background = Brushes.Red;
            }
            if (Colour == 2)
            {
                btn.Background = Brushes.LimeGreen;
            }
            if (Colour == 3)
            {
                btn.Background = Brushes.Blue;
            }
            if (Colour == 4)
            {
                btn.Background = Brushes.White;
            }
            if (Colour == 5)
            {
                btn.Background = Brushes.Cyan;
            }
            if (Colour == 6)
            {
                btn.Background = Brushes.Purple;
            }
            if (Colour == 7)
            {
            btn.Background = Brushes.Yellow;
            }
            if (Colour == 8)
            {
                btn.Background = Brushes.SaddleBrown;
            }
            if (Colour == 9)
            {
                btn.Background = Brushes.Gray;
            }

        }

        private void BLACK_BUTTON_Click(object sender, RoutedEventArgs e)//This and the following *COLOUR*_BUTTON_Click functions 
        {                                                                //change the selected colour to *COLOUR*
            
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

        private void Button_Click_1(object sender, RoutedEventArgs e)//Clear buttons function 
        {
            MessageBoxResult result = MessageBox.Show("Do you really wish to clear your WHOLE canvas?!?", "PARTY FOUL", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)//If user selects Yes box on pop up message it clears
            {
                foreach (Button btn in GRID_25.Children) //Clear function in the case that the canvas is 25x25
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        Button b = (Button)btn;
                        b.Background = Brushes.White;
                    }
                }//end of 25x25 clear

                foreach (Button btn in GRID_50.Children)//Clear function in the case that the canvas is 50x50
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        Button b = (Button)btn;
                        b.Background = Brushes.White;
                    }
                }//end of 50x50 clear

                foreach (Button btn in GRID_75.Children)//Clear funtion in the case that the canvas is 75x75
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        Button b = (Button)btn;
                        b.Background = Brushes.White;
                    }
                }//end of 75x75 clear

                foreach (Button btn in GRID_100.Children)//Clear function in the case that the canvas is 100x100 or not a perfect square
                {                                        //Note** This is still called if height and width are not the same because the
                    if (btn.GetType() == typeof(Button)) //100x100 grid is still used to ensure that the canvas does actually fit regardless
                    {                                    //of the size
                        Button b = (Button)btn;
                        b.Background = Brushes.White;
                    }
                }//end of 100x100-- clear

            }//end of if conditional to clear
            else//if the user picks no return to the program and the message closes withou clearing the canvas
            {
                return;
            }//end of else conditional to abort clear

        }//end of clear buttons function

        private void Height_Label_Click(object sender, RoutedEventArgs e)//just displays width and height
        {

        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)//not yet implemented
        {

        }

        private void Width_Label_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Load_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
