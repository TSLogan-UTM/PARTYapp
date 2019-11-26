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
        public WorkGrid(int height, int width)
        {
            InitializeComponent();
            WorkingGrid.ShowGridLines = false;
            ToolBar eventHandler = new ToolBar();
            eventHandler.Topmost = true;
            eventHandler.Show();
            AppWindow = this;

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
            int grid = 25*25*3;
            int[] array = new int[grid];

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
                for (int j = 0; j < grid; j++)
                {

                        file.WriteLine(array[j]);
 
                }
            }
            
        }
        
        public void Load_RGB_Values(string FileLocation)
        {
            int grid = 25*25*3;
            int[] array = new int[grid];


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (System.IO.StreamReader file = new System.IO.StreamReader(System.IO.Path.Combine(docPath, FileLocation)))
            {

                for (int i = 0; i < 625 * 3; i++)
                {

                    array[i] = int.Parse(file.ReadLine());
                 }

            }
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
        
    
    }
}
