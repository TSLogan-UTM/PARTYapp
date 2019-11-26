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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoadFile : Window
    {
        string FileName;
        string FileLocation;
        public LoadFile()
        {
            InitializeComponent();
        }

        private void BtnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            FileLocation = FileName + ".txt";

            PARTYapp.WorkGrid.AppWindow.Load_RGB_Values(FileLocation);
            this.Close();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FileName = InputLoad.Text;
        }
    }
}
