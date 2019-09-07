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
    /// BookdeleteWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class BookdeleteWindow1 : Window
    {
        public BookdeleteWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ID = this.IDS.Text.Trim();
            string name = this.bookname.Text.Trim();
            string cbs = this.cbs.Text.Trim();
            string price = this.price.Text.Trim();
            string kc = this.kc.Text.Trim();
            if (ID == "" || name == "" || cbs == "" || price == "" || kc == "")
            {
                // 有信息未填
                MessageBox.Show("所有信息不能为空!");
                return;
            }
            int count;
            int id = int.Parse(ID);
            decimal prices = decimal.Parse(price);
            int store = int.Parse(kc);
            BookBLL bookball = new BookBLL();
            count = bookball.BookDelete(id, name, cbs,prices,store);
            if (count == 0)
            {
                MessageBox.Show("查无此书!");
            }
            else {
                MessageBoxResult boxResult = MessageBox.Show("数据删除成功！", "提示：", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);
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
