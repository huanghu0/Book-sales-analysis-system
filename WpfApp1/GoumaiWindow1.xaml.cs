using BookStore.BLL;
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
using BookStore.Model;

namespace WpfApp1
{
    /// <summary>
    /// GoumaiWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class GoumaiWindow1 : Window
    {
        public GoumaiWindow1()
        {
            InitializeComponent();
        }
        private void ReturnMain_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Show();
            this.Hide();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            yonghugongnengWindow1 yonghugongnengWindow = new yonghugongnengWindow1();
            yonghugongnengWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            yonghugongnengWindow.Left = this.Left;
            yonghugongnengWindow.Top = this.Top;
            yonghugongnengWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string bookname = TextSelected.Text.Trim();
            BookBLL bookball = new BookBLL();
            List<Book> books = new List<Book>();
            books = bookball.SelectBooks(bookname);
            if (books.Count > 0)
            {
                DingdanWindow1 DingdanWindow = new DingdanWindow1();
                DingdanWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                DingdanWindow.Left = this.Left;
                DingdanWindow.Top = this.Top;
                DingdanWindow.Show();
                this.Close();
                string name = books[0].Name;
                string price = books[0].Price.ToString();
                DingdanWindow.TextBookName.Text = name;
                DingdanWindow.TextPrice.Text = price;
                
            }
            else
            {
                MessageBox.Show("查无此书!");
            }
        }
    }
}
