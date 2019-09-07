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

namespace WpfApp1
{
    /// <summary>
    /// UserWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class UserWindow1 : Window
    {
        public UserWindow1()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserChangeWindow1 UserChangeWindow = new UserChangeWindow1();
            //loginWindow.Show();
            UserChangeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            UserChangeWindow.Left = this.Left;
            UserChangeWindow.Top = this.Top;
            UserChangeWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AdminWindow1 AdminWindow = new AdminWindow1();
            AdminWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            AdminWindow.Left = this.Left;
            AdminWindow.Top = this.Top;
            AdminWindow.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //   BookStore.BLL.UserBLL user = new UserBLL();
            //  user.Delete();
            SoftdeleteUsersWindow1 SoftdeleteUsersWindow = new SoftdeleteUsersWindow1();
            SoftdeleteUsersWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            SoftdeleteUsersWindow.Left = this.Left;
            SoftdeleteUsersWindow.Top = this.Top;
            SoftdeleteUsersWindow.Show();
            this.Close();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
