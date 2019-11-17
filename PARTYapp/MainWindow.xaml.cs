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
            app.GRID_100.ShowGridLines = false;
            app.GRID_75.ShowGridLines = false;
            app.GRID_50.ShowGridLines = false;
            app.GRID_25.ShowGridLines = false;

            int width = Convert.ToInt32(WidthBox.Text);
            int height = Convert.ToInt32(HeightBox.Text);

            if (width == height)//Checks if grid is a square (this is ideal)
            {
                if (width == 25) // in the case that width does equal height and either is equal to 25
                {
                    int count = 1;

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            
                            Button MyControl1 = new Button();
                            MyControl1.Content = "";
                            MyControl1.Name = "Button" + count.ToString();
                            MyControl1.Background = Brushes.White;
                            MyControl1.Click += new RoutedEventHandler(app.Button_Click);

                            Grid.SetColumn(MyControl1, j);
                            Grid.SetRow(MyControl1, i);
                            app.GRID_25.Children.Add(MyControl1);

                            count++;
                        }

                    }
                } //End of if statement for 25

                if (width == 50) // in the case that width does equal height and either is equal to 50
                {
                    int count = 1;

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Button MyControl1 = new Button();
                            MyControl1.Content = "";
                            MyControl1.Name = "Button" + count.ToString();
                            MyControl1.Background = Brushes.White;
                            MyControl1.Click += new RoutedEventHandler(app.Button_Click);

                            Grid.SetColumn(MyControl1, j);
                            Grid.SetRow(MyControl1, i);
                            app.GRID_50.Children.Add(MyControl1);

                            count++;
                        }

                    }
                }//End of if statement for 50

                if (width == 75) // in the case that width does equal height and either is equal to 75
                {
                    int count = 1;

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Button MyControl1 = new Button();
                            MyControl1.Content = "";
                            MyControl1.Name = "Button" + count.ToString();
                            MyControl1.Background = Brushes.White;
                            MyControl1.Click += new RoutedEventHandler(app.Button_Click);

                            Grid.SetColumn(MyControl1, j);
                            Grid.SetRow(MyControl1, i);
                            app.GRID_75.Children.Add(MyControl1);

                            count++;
                        }

                    }
                }//End of if statement for 75

                if (width == 100) // in the case that width does equal height and either is equal to 100
                {
                    int count = 1;

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Button MyControl1 = new Button();
                            MyControl1.Content = "";
                            MyControl1.Name = "Button" + count.ToString();
                            MyControl1.Background = Brushes.White;
                            MyControl1.Click += new RoutedEventHandler(app.Button_Click);

                            Grid.SetColumn(MyControl1, j);
                            Grid.SetRow(MyControl1, i);
                            app.GRID_100.Children.Add(MyControl1);

                            count++;
                        }

                    }
                }//End of if statement for 100
            }//End of large if statement that checks for squares and reacts accordingly
            else//incase the canvas is not a perfect square and the 100x100 grid has to be use to ensure all pixels fit
            {
                int count = 1;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Button MyControl1 = new Button();
                        MyControl1.Content = "";
                        MyControl1.Name = "Button" + count.ToString();
                        MyControl1.Background = Brushes.White;
                        MyControl1.Click += new RoutedEventHandler(app.Button_Click);

                        Grid.SetColumn(MyControl1, j);
                        Grid.SetRow(MyControl1, i);
                        app.GRID_100.Children.Add(MyControl1);

                        count++;
                    }

                }
            }
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
