using BookStore;
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
    /// adminiRegister.xaml 的交互逻辑
    /// </summary>
    public partial class adminiRegister : Window
    {
        public adminiRegister()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //接收用户输入数据
            string name = this.txtName.Text.Trim();
            string password = this.txtPassword.Password.Trim();
            if (name == "" || password == "")
            {
                // 用户名密码为空
                MessageBox.Show("用户名或密码不能为空!");
                return;
            }

            User user = null;
            BookStore.BLL.UserBLL bll = new UserBLL();

            bool flag = false;

            flag = bll.Login(name, password, out user);

            if (flag)
            {
                //不把密码保存在内存中
                user.Password = null;
                //登录成功记录登录者的信息
                Common.LoginUser = user;
                //登录成功
                //MessageBox.Show("登录成功!");
                AdminWindow1 AdminWindow = new AdminWindow1();
                //loginWindow.Show();
                AdminWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                AdminWindow.Left = this.Left;
                AdminWindow.Top = this.Top;
                AdminWindow.Show();
                this.Close();
            }
            else
            {
                //登录失败
                MessageBox.Show("用户名或密码错误!");
            }

           /*
            AdminWindow1 AdminWindow = new AdminWindow1();
            //loginWindow.Show();
            AdminWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            AdminWindow.Left = this.Left;
            AdminWindow.Top = this.Top;
            AdminWindow.Show();
            this.Close();*/
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            chooseUserTypeWindow1 chooseUserTypeWindow = new chooseUserTypeWindow1();
            //loginWindow.Show();
            chooseUserTypeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            chooseUserTypeWindow.Left = this.Left;
            chooseUserTypeWindow.Top = this.Top;
            chooseUserTypeWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow1 loginWindow = new LoginWindow1();
            //loginWindow.Show();
            loginWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            loginWindow.Left = this.Left;
            loginWindow.Top = this.Top;
            loginWindow.Show();
            this.Close();
        }
    }
}
