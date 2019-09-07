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
using BookStore.BLL;

namespace WpfApp1
{
    /// <summary>
    /// UserChangeWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class UserChangeWindow1 : Window
    {
        public UserChangeWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ID = Txt_ID.Text.Trim();
            string Birthday = Txt_birthday.Text.Trim();
            string email = Txt_email.Text.Trim();
            string Type = Txt_type.Text.Trim();
            int count = 0;
            UserBLL userbll = new UserBLL();
            if (ID == "" || Birthday == "" || email == "" || Type == "")
            {
                // 有信息未填
                MessageBox.Show("所有信息不能为空!");
                return;
            }
            int id = int.Parse(ID);
            DateTime birthday = DateTime.Parse(Birthday);
            int type = int.Parse(Type);
            count = userbll.Updateinform(id,birthday,email,type);
            if (count > 0) {

                MessageBoxResult boxResult = MessageBox.Show("数据修改成功！", "提示：", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);
                if (boxResult == MessageBoxResult.Yes)
                {
                    UserWindow1 UserWindow = new UserWindow1();
                    UserWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                    UserWindow.Left = this.Left;
                    UserWindow.Top = this.Top;
                    UserWindow.Show();
                    UserBLL user = new UserBLL();
                    UserWindow.dataGrid.ItemsSource = user.GetAllUsers();
                    this.Close();
                }
                else {
                    MessageBox.Show("查无此人!");
                }
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            UserWindow1 UserWindow = new UserWindow1();
            UserWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            UserWindow.Left = this.Left;
            UserWindow.Top = this.Top;
            UserWindow.Show();
            BookStore.BLL.UserBLL user = new UserBLL();
            UserWindow.dataGrid.ItemsSource = user.GetAllUsers();
            this.Close();
        }
    }
}
