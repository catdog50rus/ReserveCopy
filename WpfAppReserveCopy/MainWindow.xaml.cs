using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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

namespace WpfAppReserveCopy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProgramClose_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void ButtonCatalog_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog oc = new OpenFileDialog();
            //oc.ShowDialog();
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            string folder = fb.SelectedPath;
            
        }
    }
}
