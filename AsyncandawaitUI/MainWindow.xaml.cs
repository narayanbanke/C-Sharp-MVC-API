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
using System.IO;
using System.Threading;

namespace AsyncandawaitUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int countcharacters()
        {
            int count = 0;
            using (StreamReader a =new  StreamReader("D:\\Narayan\\CsharpTrainingConsultant\\Day21\\AsyncandawaitUI.txt") )
            {
                string content = a.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private  void btnprocess_Click(object sender, RoutedEventArgs e)
        {
            lblinfo.Content = "processing file please wait";         
            int count1 = countcharacters();
            lblinfo.Content = "characters" + count1;
        }
    }
}
