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
    /// yonghugongnengWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class yonghugongnengWindow1 : Window
    {
        public yonghugongnengWindow1()
        {
            InitializeComponent();
        }

        private void BtnPercenter_click(object sender, RoutedEventArgs e)
        {
            chooseUserTypeWindow1 chooseUserTypeWindow = new chooseUserTypeWindow1();
            //loginWindow.Show();
            chooseUserTypeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            chooseUserTypeWindow.Left = this.Left;
            chooseUserTypeWindow.Top = this.Top;
            chooseUserTypeWindow.Show();
            this.Close();
        }

        private void Btnlogistra_click(object sender, RoutedEventArgs e)
        {
            WuliugenzongWindow1 WuliugenzongWindow = new WuliugenzongWindow1();
            //loginWindow.Show();
            WuliugenzongWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            WuliugenzongWindow.Left = this.Left;
            WuliugenzongWindow.Top = this.Top;
            WuliugenzongWindow.Show();
            this.Close();
        }

        private void Btn_Order(object sender, RoutedEventArgs e)
        {
            GoumaiWindow1 GoumaiWindow = new GoumaiWindow1();
            GoumaiWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            GoumaiWindow.Left = this.Left;
            GoumaiWindow.Top = this.Top;
            GoumaiWindow.Show();
            this.Close();
        }

        private void BtnDatanly_click(object sender, RoutedEventArgs e)
        {
            DataAnalysizeWindow1 DataAnalysizeWindow = new DataAnalysizeWindow1();
            DataAnalysizeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            DataAnalysizeWindow.Left = this.Left;
            DataAnalysizeWindow.Top = this.Top;
            DataAnalysizeWindow.Show();
            this.Close();
        }

        private void BtnPercenter_click1(object sender, RoutedEventArgs e)
        {
            IndexWindow1 IndexWindow = new IndexWindow1();
            IndexWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            IndexWindow.Left = this.Left;
            IndexWindow.Top = this.Top;
            IndexWindow.Show();
            this.Close();
        }
    }
}
