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
using BookStore.BLL;

namespace WpfApp1
{
    /// <summary>
    /// DingdanWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class DingdanWindow1 : Window
    {
        public DingdanWindow1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GoumaiWindow1 GoumaiWindow = new GoumaiWindow1();
            GoumaiWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            GoumaiWindow.Left = this.Left;
            GoumaiWindow.Top = this.Top;
            GoumaiWindow.Show();
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string booksname = TextBookName.Text;
            string ordername = TextOrdername.Text;
            string address = TextAddress.Text;
            string username = TextSeller.Text;
            int buycount = int.Parse(TextCount.Text);
            int count = 0;
            AllorderBLL allorderbll = new AllorderBLL();
            count = allorderbll.OrderBook(booksname,buycount,ordername,address,username);
            if (count != 0)
            {
                MessageBox.Show("下单成功!");
            }
            else {
                MessageBox.Show("查无此书!");
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
