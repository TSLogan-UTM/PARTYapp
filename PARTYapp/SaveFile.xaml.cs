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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SaveFile : Window
    {
        string FileName;
        string FileLocation;
        public SaveFile()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            FileLocation = FileName + ".txt";

            PARTYapp.WorkGrid.AppWindow.Save_RGB_Values(FileLocation);
            MessageBox.Show("Canvas was saved to My Documents.", "PARTY FOUL");
            this.Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FileName = InputSave.Text;
        }
    }
}
