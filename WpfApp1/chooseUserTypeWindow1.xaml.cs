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

namespace WpfApp1
{
    /// <summary>
    /// chooseUserTypeWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class chooseUserTypeWindow1 : Window
    {
        public chooseUserTypeWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adminiRegister adminiRegister1 = new adminiRegister();
            adminiRegister1.WindowStartupLocation = WindowStartupLocation.Manual;
            adminiRegister1.Left = this.Left;
            adminiRegister1.Top = this.Top;
            adminiRegister1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AboutUsWindow1 AboutUsWindow = new AboutUsWindow1();
            AboutUsWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            AboutUsWindow.Left = this.Left;
            AboutUsWindow.Top = this.Top;
            AboutUsWindow.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }
    }
}
