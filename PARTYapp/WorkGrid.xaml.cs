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
    /// Interaction logic for WorkGrid.xaml
    /// </summary>
    public partial class WorkGrid : Window
    {
        public static WorkGrid AppWindow;
        public WorkGrid(int height, int width)
        {
            InitializeComponent();
            WorkingGrid.ShowGridLines = false;
            ToolBar eventHandler = new ToolBar();
            eventHandler.Topmost = true;
            eventHandler.Show();
            AppWindow = this;

            // Declare variables to make the canvas larger based on values.
            // If height is 25 or less.
            if (height <= 25)
            {
                if (width <= 25)
                {
                    this.Height = height * 24;
                    this.Width = width * 24;
                }

                else if (width > 25 && width <= 50)
                {
                    this.Height = height * 23;
                    this.Width = width * 22;
                }

                else if (width > 50 && width <= 75)
                {
                    this.Height = height * 17;
                    this.Width = width * 15;
                }

                else
                {
                    this.Height = height * 15.5;
                    this.Width = width * 11.5;
                }
            }

            // If height is between 26 and 50.
            if (height > 25 && height <= 50)
            {
                if (width <= 25)
                {
                    this.Height = height * 12;
                    this.Width = width * 16;
                }

                else if (width > 25 && width <= 50)
                {
                    this.Height = height * 12;
                    this.Width = width * 12;
                }

                else if (width > 50 && width <= 75)
                {
                    this.Height = height * 12;
                    this.Width = width * 12;
                }

                else
                {
                    this.Height = height * 11.5;
                    this.Width = width * 10.5;
                }
            }

            // If height is between 51 and 75.
            if (height > 50 && height <= 75)
            {
                if (width <= 25)
                {
                    this.Height = height * 8;
                    this.Width = width * 10;
                }

                else if (width > 25 && width <= 50)
                {
                    this.Height = height * 8;
                    this.Width = width * 9.5;
                }

                else if (width > 50 && width <= 75)
                {
                    this.Height = height * 8;
                    this.Width = width * 8;
                }

                else
                {
                    this.Height = height * 8;
                    this.Width = width * 9.5;
                }
            }

            // If height is between 76 and 100.
            if (height > 75 && height <= 100)
            {
                if (width <= 25)
                {
                    this.Height = height * 6;
                    this.Width = width * 8.5;
                }

                else if (width > 25 && width <= 50)
                {
                    this.Height = height * 6;
                    this.Width = width * 8.5;
                }

                else if (width > 50 && width <= 75)
                {
                    this.Height = height * 6;
                    this.Width = width * 8.5;
                }

                else
                {
                    this.Height = height * 6;
                    this.Width = width * 6;
                }
            }


            for (int i = 0; i < width; i++)
            {
                WorkingGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for(int i = 0; i < height; i++)
            {
                WorkingGrid.RowDefinitions.Add(new RowDefinition());
            }
            
            for (int row = 0; row < WorkingGrid.RowDefinitions.Count; row++)
            {
                for(int col = 0; col < WorkingGrid.ColumnDefinitions.Count; col++)
                {

                    Button MyControl1 = new Button();
                    MyControl1.Content = "";
                    MyControl1.Name = "Button" + col.ToString();
                    MyControl1.Background = Brushes.White;
                    MyControl1.Click += new RoutedEventHandler(eventHandler.Button_Click);
                    Grid.SetColumn(MyControl1, col);
                    Grid.SetRow(MyControl1, row);
                    WorkingGrid.Children.Add(MyControl1);
                }
            }
            
        }
        public void clear()
        {
            foreach(Button btn in WorkingGrid.Children)
            {
                Button b = (Button)btn;
                b.Background = Brushes.White;
            }
        }
    }
}
