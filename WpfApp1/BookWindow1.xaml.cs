using System.Windows;
using System.Windows.Controls;
using BookStore.BLL;

namespace WpfApp1
{
    /// <summary>
    /// BookWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class BookWindow1 : Window
    {
        

        public BookWindow1()
        {
            InitializeComponent();
            //initList();
        }
       

        private void dgDataSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookAddWindow1 BookAddWindow = new BookAddWindow1();
            //loginWindow.Show();
            BookAddWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            BookAddWindow.Left = this.Left;
            BookAddWindow.Top = this.Top;
            BookAddWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminWindow1 AdminWindow = new AdminWindow1();
            AdminWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            AdminWindow.Left = this.Left;
            AdminWindow.Top = this.Top;
            AdminWindow.Show();
            this.Close();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            BookWindow1 BookWindow = new BookWindow1();
            BookWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            BookWindow.Left = this.Left;
            BookWindow.Top = this.Top;
            BookWindow.Show();
            BookBLL book = new BookBLL();
            BookWindow.dataGrid.ItemsSource = book.GetAllBooks();
            this.Close();
        }

        private void Button_deleteBook(object sender, RoutedEventArgs e)
        {
            BookdeleteWindow1 bookdeleteWindow1 = new BookdeleteWindow1();
            //loginWindow.Show();
            bookdeleteWindow1.WindowStartupLocation = WindowStartupLocation.Manual;
            bookdeleteWindow1.Left = this.Left;
            bookdeleteWindow1.Top = this.Top;
            bookdeleteWindow1.Show();
            this.Close();
        }

        private void Button_Select(object sender, RoutedEventArgs e)
        {
            string name = TextSelectbook.Text.Trim();
            BookBLL bookball = new BookBLL();
            if (bookball.SelectBooks(name).Count > 0)
            {
                BookWindow1 BookWindow = new BookWindow1();
                BookWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                BookWindow.Left = this.Left;
                BookWindow.Top = this.Top;
                BookWindow.Show();
                BookBLL book = new BookBLL();
                BookWindow.dataGrid.ItemsSource = book.SelectBooks(name);
                this.Close();
            }
            else {
                MessageBox.Show("查无此书!");
            }
        }
    }
}
