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
    /// DataAnalysizeWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class DataAnalysizeWindow1 : Window
    {
        public DataAnalysizeWindow1()
        {
            InitializeComponent();
        }
        private void ReturnMain_click(object sender, RoutedEventArgs e)
        {
            yonghugongnengWindow1 yonghugongnengWindow = new yonghugongnengWindow1();
            //loginWindow.Show();
            yonghugongnengWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            yonghugongnengWindow.Left = this.Left;
            yonghugongnengWindow.Top = this.Top;
            yonghugongnengWindow.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTypeWindow1 DataTypeWindow = new DataTypeWindow1();
            //loginWindow.Show();
            DataTypeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            DataTypeWindow.Left = this.Left;
            DataTypeWindow.Top = this.Top;
            DataTypeWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void ComBox_quater_DropDownClosed(object sender, EventArgs e)
        {
            string str = ComBox_quater.Text;
            string username = Common.LoginUser.Name;
            QuaterinformationBLL QuaterinformBll = new QuaterinformationBLL();
            int quater;
            switch (str)
            {
                case "第一季度":
                    quater = 1;
                    break;
                case "第二季度":
                    quater = 2;
                    break;
                case "第三季度":
                    quater = 3;
                    break;
                case "第四季度":
                    quater = 4;
                    break;
                default:
                    quater = 0;
                    str = "季度不能为空";
                    break;
            }
            if (quater != 0)
            {
                str = QuaterinformBll.GetQuater(quater, username);
            }
            if (str != null)
            {
                TextData.Text = str;
            }
        }
    }
}
