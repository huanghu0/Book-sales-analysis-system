using System.Windows;
using BookStore.BLL;
namespace WpfApp1
{
    /// <summary>
    /// AdminWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class AdminWindow1 : Window
    {
        public AdminWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookWindow1 BookWindow = new BookWindow1();
            BookWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            BookWindow.Left = this.Left;
            BookWindow.Top = this.Top;
            BookWindow.Show();
            BookStore.BLL.BookBLL book = new BookBLL();
            BookWindow.dataGrid.ItemsSource = book.GetAllBooks();



    
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            UserWindow1 UserWindow = new UserWindow1();
            //loginWindow.Show();
            UserWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            UserWindow.Left = this.Left;
            UserWindow.Top = this.Top;
            UserWindow.Show();
            BookStore.BLL.UserBLL user = new UserBLL();
            UserWindow.dataGrid.ItemsSource = user.GetAllUsers();
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            adminiRegister adminiRegister1 = new adminiRegister();
            //loginWindow.Show();
            adminiRegister1.WindowStartupLocation = WindowStartupLocation.Manual;
            adminiRegister1.Left = this.Left;
            adminiRegister1.Top = this.Top;
            adminiRegister1.Show();
            this.Close();
        }
    }
}
