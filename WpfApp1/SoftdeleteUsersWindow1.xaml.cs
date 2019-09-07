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
using BookStore;
using BookStore.BLL;
using BookStore.Model;


namespace WpfApp1
{
    /// <summary>
    /// SoftdeleteUsersWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class SoftdeleteUsersWindow1 : Window
    {
        public SoftdeleteUsersWindow1()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            UserWindow1 UserWindow = new UserWindow1();
            //loginWindow.Show();
            UserWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            UserWindow.Left = this.Left;
            UserWindow.Top = this.Top;
            UserWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Id = this.txtId.Text.Trim();
            string name = this.txtName.Text.Trim();
            string Mail = this.txtMail.Text.Trim();
            string Type = this.txtType.Text.Trim();
            if (Type == "" || name == "" || Id == "" || Mail == "")
            {
                // 有信息未填
                MessageBox.Show("所有信息不能为空!");
                return;
            }
            User user = null;
            BookStore.BLL.UserBLL bll = new UserBLL();
            int flag = 0;
            /*user.Id = Convert.ToInt32(this.txtId.Text.Trim());//int.Parse(ID);
            user.Name = name;
            user.Email = this.txtMail.Text.Trim();
            user.Type = Convert.ToInt32(this.txtType.Text.Trim());*/
            flag = bll.Softdelete(Id);
            if (flag == 1)
            {
                MessageBoxResult boxResult = MessageBox.Show("删除成功！", "提示：", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);
                if (boxResult == MessageBoxResult.Yes)
                {
                    UserWindow1 UserWindow = new UserWindow1();
                    UserWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                    UserWindow.Left = this.Left;
                    UserWindow.Top = this.Top;
                    UserWindow.Show();
                    this.Close();
                }
            }

        }
    }
}
