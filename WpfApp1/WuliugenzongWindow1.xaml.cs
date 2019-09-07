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
    /// WuliugenzongWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class WuliugenzongWindow1 : Window
    {
        public WuliugenzongWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fahuowuliuWindow1 fahuowuliuWindow = new fahuowuliuWindow1();
            fahuowuliuWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            fahuowuliuWindow.Left = this.Left;
            fahuowuliuWindow.Top = this.Top;
            fahuowuliuWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fahuowuliuWindow1 fahuowuliuWindow = new fahuowuliuWindow1();
            fahuowuliuWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            fahuowuliuWindow.Left = this.Left;
            fahuowuliuWindow.Top = this.Top;
            fahuowuliuWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            yonghugongnengWindow1 yonghugongnengWindow = new yonghugongnengWindow1();
            yonghugongnengWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            yonghugongnengWindow.Left = this.Left;
            yonghugongnengWindow.Top = this.Top;
            yonghugongnengWindow.Show();
            this.Close();
        }
    }
}
