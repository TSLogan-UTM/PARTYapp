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
