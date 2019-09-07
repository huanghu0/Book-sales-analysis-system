using BookStore.BLL;
using BookStore.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// BookAddWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class BookAddWindow1 : Window
    {
        public BookAddWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ID = this.IDS.Text.Trim();
            string name = this.bookname.Text.Trim();
            string author = this.cbs.Text.Trim();
            string price = this.price.Text.Trim();
            string store = this.store.Text.Trim();
            if (ID == "" || name == "" || author == "" || price == "" || store == "")
            {
                // 有信息未填
                MessageBox.Show("所有信息不能为空!");
                return;
            }
            Book book = new Book();
            BookStore.BLL.BookBLL bll = new BookBLL();
            bool flag = false;
            book.Id = Convert.ToInt32(this.IDS.Text.Trim());//int.Parse(ID);
            book.Name = name;
            book.Price = Convert.ToDouble(this.price.Text.Trim());
            book.store = Convert.ToInt32(store);
            book.Author = author;
            flag = bll.AddBook(book);
            if (flag)
            {
                MessageBoxResult boxResult = MessageBox.Show("图书信息添加成功！", "提示：", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);
                if (boxResult == MessageBoxResult.Yes)
                {
                    BookWindow1 BookWindow = new BookWindow1();
                    BookWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                    BookWindow.Left = this.Left;
                    BookWindow.Top = this.Top;
                    BookWindow.Show();
                    this.Close();
                }
            }

            /*   
                Book book = new Book();
                BookStore.BLL.BookBLL bll = new BookBLL();
                bool flag = false;
                book.Id =int.Parse(ID);
                book.Name = name;
                book.Price = int.Parse(price);
                book.Inventory = int.Parse(kc);
                book.Author = cbs;

                flag = bll.AddBook(book);
                if (flag)
                {

                }*/

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BookWindow1 BookWindow = new BookWindow1();
            BookWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            BookWindow.Left = this.Left;
            BookWindow.Top = this.Top;
            BookWindow.Show();
            this.Close();
        }

        private void ISBN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
