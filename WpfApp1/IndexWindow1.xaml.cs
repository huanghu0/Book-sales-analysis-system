using BookStore;
using BookStore.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using BookStore.BLL;

namespace WpfApp1
{
    /// <summary>
    /// IndexWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class IndexWindow1 : Window
    {
        public IndexWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string Personinformation = "用户名:" + Common.LoginUser.Name + "\r\n" + "用户类型:" + Common.LoginUser.Type + "\r\n" + "邮箱:" + Common.LoginUser.Email + "\r\n" + "生日:" + Common.LoginUser.Birthday + "\r\n";

            indexPage1 p1 = null;
            if (p1 == null)
            {
                p1 = new indexPage1();
            }
            p1.Content = Personinformation;
            change.Content = new Frame()
            { Content = p1 };

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = Common.LoginUser.Name;
            AllorderBLL allorderBLL = new AllorderBLL();
            string str = allorderBLL.GetAllorders(username);
            indexPage2 p2 = null;
            if (p2 == null)
            {
                p2 = new indexPage2();
            }
            p2.Content = str;
            change.Content = new Frame()
            { Content = p2 };
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
