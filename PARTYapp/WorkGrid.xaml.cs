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
using System.IO;
namespace PARTYapp
{
    /// <summary>
    /// Interaction logic for WorkGrid.xaml
    /// </summary>
    public partial class WorkGrid : Window
    {
        public static WorkGrid AppWindow;

        //Used to keep track of Canvas Dimensions.
        int canvas_height, canvas_width;
        public WorkGrid(int height, int width)
        {
            InitializeComponent();
            WorkingGrid.ShowGridLines = false;
            ToolBar eventHandler = new ToolBar();
            eventHandler.Topmost = true;
            eventHandler.Show();
            AppWindow = this;

            canvas_height = height;
            canvas_width = width;

            // Check user's computer to see if they have terrible resolution...
            double screenHeight = SystemParameters.PrimaryScreenHeight;

            // Declare variables to set offset of the grid window.
            double windowWidth;
            double windowHeight;

            if (screenHeight >= 900)
            {

                // Declare variables to make the canvas larger based on values.
                // If height is 25 or less.
                if (height <= 25)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 24;
                        this.Width = width * 24;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 24;
                        windowWidth = width * 24;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 23;
                        this.Width = width * 22;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 23;
                        windowWidth = width * 22;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 17;
                        this.Width = width * 15;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 17;
                        windowWidth = width * 15;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 15.5;
                        this.Width = width * 11.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 15.5;
                        windowWidth = width * 11.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }

                // If height is between 26 and 50.
                if (height > 25 && height <= 50)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 12;
                        this.Width = width * 16;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 12;
                        windowWidth = width * 16;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 12;
                        this.Width = width * 12;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 12;
                        windowWidth = width * 12;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 12;
                        this.Width = width * 12;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 12;
                        windowWidth = width * 12;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 11.5;
                        this.Width = width * 10.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 11.5;
                        windowWidth = width * 10.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }

                // If height is between 51 and 75.
                if (height > 50 && height <= 75)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 8;
                        this.Width = width * 10;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 8;
                        windowWidth = width * 10;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 8;
                        this.Width = width * 9.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 8;
                        windowWidth = width * 9.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 8;
                        this.Width = width * 8;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 8;
                        windowWidth = width * 8;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 8;
                        this.Width = width * 9.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 8;
                        windowWidth = width * 9.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }

                // If height is between 76 and 100.
                if (height > 75 && height <= 100)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 6;
                        this.Width = width * 8.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 8.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 6;
                        this.Width = width * 8.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 8.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 6;
                        this.Width = width * 8.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 8.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 6;
                        this.Width = width * 6;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 6;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }
            }

            if (screenHeight < 900)
            {

                // Declare variables to make the canvas larger based on values.
                // If height is 25 or less.
                if (height <= 25)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 22;
                        this.Width = width * 22;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 22;
                        windowWidth = width * 22;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 17;
                        this.Width = width * 20;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 17;
                        windowWidth = width * 20;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.25;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 15;
                        this.Width = width * 13;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 15;
                        windowWidth = width * 13;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.3;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 13.5;
                        this.Width = width * 9.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 13.5;
                        windowWidth = width * 9.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.3;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }

                // If height is between 26 and 50.
                if (height > 25 && height <= 50)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 10;
                        this.Width = width * 14;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 10;
                        windowWidth = width * 14;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 10;
                        this.Width = width * 10;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 10;
                        windowWidth = width * 10;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.75;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 10;
                        this.Width = width * 10;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 10;
                        windowWidth = width * 10;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.5;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 9.5;
                        this.Width = width * 8.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 9.5;
                        windowWidth = width * 8.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.4;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }

                // If height is between 51 and 75.
                if (height > 50 && height <= 75)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 6;
                        this.Width = width * 8;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 8;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 6;
                        this.Width = width * 7.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 7.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 6;
                        this.Width = width * 6;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 6;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.75;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else
                    {
                        this.Height = height * 6;
                        this.Width = width * 7.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 6;
                        windowWidth = width * 7.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 1.75;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }

                // If height is between 76 and 100.
                if (height > 75 && height <= 100)
                {
                    if (width <= 25)
                    {
                        this.Height = height * 5.5;
                        this.Width = width * 6.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 5.5;
                        windowWidth = width * 6.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }

                    else if (width > 25 && width <= 50)
                    {
                        this.Height = height * 5.5;
                        this.Width = width * 6.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 4;
                        windowWidth = width * 6.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 4;
                    }

                    else if (width > 50 && width <= 75)
                    {
                        this.Height = height * 5.5;
                        this.Width = width * 6.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 4;
                        windowWidth = width * 6.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 4;
                    }

                    else
                    {
                        this.Height = height * 5.5;
                        this.Width = width * 5.5;

                        // Dyanmically set grid window position based on window size.
                        windowHeight = height * 5.5;
                        windowWidth = width * 5.5;
                        this.Left = (SystemParameters.PrimaryScreenWidth - windowWidth) / 2;
                        this.Top = (SystemParameters.PrimaryScreenHeight - windowHeight) / 3;
                    }
                }
                
            }


            for (int i = 0; i < width; i++)
            {
                WorkingGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < height; i++)
            {
                WorkingGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int row = 0; row < WorkingGrid.RowDefinitions.Count; row++)
            {
                for (int col = 0; col < WorkingGrid.ColumnDefinitions.Count; col++)
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

            foreach (Button btn in WorkingGrid.Children)
            {
                Button b = (Button)btn;
                b.Background = Brushes.White;

            }

        }
        public void Save_RGB_Values(string FileLocation)
        {
            /* Pull the height and width of the current workgrid then multiply by 3
               to make enough room for all RGB values. Must be double because system
               spec queries return doubles.*/
            double grid = canvas_height * canvas_width * 3;

            // Convert that to an int to integrate with current code.
            int grid2 = Convert.ToInt32(grid);
            int[] array = new int[grid2];

            int i = 0;
            foreach (Button btn in WorkingGrid.Children)
            {
                
                Button b = (Button)btn;
                var color = ((SolidColorBrush)b.Background).Color;
                array[i] = color.R;
                i++;
                array[i] = color.G;
                i++;
                array[i] = color.B;
                i++;
                

            }

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(System.IO.Path.Combine(docPath, FileLocation)))
            {
                file.WriteLine(canvas_height);
                file.WriteLine(canvas_width);
                for (int j = 0; j < grid2; j++)
                {

                    file.WriteLine(array[j]);

                }
            }

        }

        public void Load_RGB_Values(string FileLocation)
        {
            /* Pull the height and width of the current workgrid then multiply by 3
               to make enough room for all RGB values. Must be double because system
               spec queries return doubles.*/
            double grid = canvas_height * canvas_width * 3;

            // Convert that to an int to integrate with current code.
            int grid2 = Convert.ToInt32(grid);
            int[] array = new int[grid2];

            double check_height, check_width;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Path.Combine(docPath, FileLocation)))
            {
                check_height = int.Parse(file.ReadLine());
                check_width = int.Parse(file.ReadLine());
                if (check_height == canvas_height && check_width == canvas_width)
                {
                    for (int i = 0; i < grid2; i++)
                    {
                        
                        array[i] = int.Parse(file.ReadLine());
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, Canvas can not load. Wrong Dimensions", "PARTY FOUL");
                }

            }
            
            if (check_height == canvas_height && check_width == canvas_width)
            {
                int j = 0;
                foreach (Button btn in WorkingGrid.Children)
                {

                    Button b = (Button)btn;
                    var color = ((SolidColorBrush)b.Background).Color;
                    color.R = (byte)array[j];
                    j++;
                    color.G = (byte)array[j];
                    j++;
                    color.B = (byte)array[j];
                    j++;
                    var brush = new SolidColorBrush(Color.FromArgb(255, color.R, color.G, color.B));
                    b.Background = brush;


                }
            }
            else
            {
                //If Dimensions are different nothing will happen
            }
        }

       public void Splash(Button New_Color, Button Old_Color)
        {
            var color_compare = ((SolidColorBrush)Old_Color.Background).Color;
            foreach (Button btn in WorkingGrid.Children)
            {
                Button bb = (Button)btn;
                var color = ((SolidColorBrush)bb.Background).Color;
               // var color_compare = ((SolidColorBrush)Old_Color.Background).Color;
                if (New_Color.Background == bb.Background)
                {
                    bb.Background = New_Color.Background;
                }
                else
                {
                   bb.Background = Old_Color.Background;
                }
                
            }
        }
    }
}