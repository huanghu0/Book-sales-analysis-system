using BookStore.BLL;
using BookStore.Model;
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
    /// LoginWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow1 : Window
    {
        public LoginWindow1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Type = this.txbUserType.Text.Trim();
            string name = this.txtUserName.Text.Trim();
            string pwd = this.Pwd.Password.Trim();
            string Mail = this.txtMail.Text.Trim();
            // string kc = this.kc.Text.Trim();
            if (Type == "" || name == "" || pwd == "" || Mail == "")
            {
                // 有信息未填
                MessageBox.Show("所有信息不能为空!");
                return;
            }

            //  Book book = new Book(int.Parse(ID), name, cbs, int.Parse(price), int.Parse(kc));
            User user = new User();
            BookStore.BLL.UserBLL bll = new UserBLL();
            bool flag = false;
            user.Type = Convert.ToInt32(this.txbUserType.Text.Trim());//int.Parse(ID);
            user.Name = name;
            user.Password = this.Pwd.Password.Trim();
            user.Email = this.txtMail.Text.Trim();


            flag = bll.AddUser(user);
            if (flag)
            {
                MessageBoxResult boxResult = MessageBox.Show("注册成功！", "提示：", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);
            }


            // MessageBox.Show("注册成功！");

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void txbUserType_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            //loginWindow.Show();
            mainWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }
    }
}
