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
    /// Interaction logic for Advanced.xaml
    /// </summary>
    public partial class Advanced : Window
    {
        // Create the toolbar window.
        ToolBar tools = new ToolBar();

        // Create the Grid Window.
        WorkGrid workspace = new WorkGrid();

        public Advanced()
        {
            InitializeComponent();
            
            // Show the toolbar in the window.
            tools.Show();
            // Make sure the window stays above the background window.
            tools.Topmost = true;

            // Show the grid in the window.
            workspace.Show();
            // Make sure the window stays above the background window.
            workspace.Topmost = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Close the toolbar at the same time the window is closed.
            tools.Close();

            // Close the grid at the same time the window is closed.
            workspace.Close();
        }
    }
}
