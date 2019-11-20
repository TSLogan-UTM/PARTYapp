﻿using System;
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
        public ToolBar()
        {
            InitializeComponent();
            
            // Set the window to open 25 pixels from the left of the user's screen.
            // See WindowStartupLocation "Top" in ToolBar.xaml for window indention from top of user's screen.
            double toolBarOffset = 25;
            this.Left = SystemParameters.PrimaryScreenWidth - (SystemParameters.PrimaryScreenWidth - (toolBarOffset));
        }


        // Trying to get this window to move.
        Point mousePosition;
        bool mouseDown;

        private void DockPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseDown = true;
        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.mousePosition = new Point();  
            }
        }
        // ----- END OF TRYING TO GET WINDOW TO MOVE. ---
    }
}