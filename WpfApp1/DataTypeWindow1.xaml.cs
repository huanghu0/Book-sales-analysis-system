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
    /// DataTypeWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class DataTypeWindow1 : Window
    {
        public DataTypeWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAnalysizeWindow1 DataAnalysizeWindow = new DataAnalysizeWindow1();
            //loginWindow.Show();
            DataAnalysizeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            DataAnalysizeWindow.Left = this.Left;
            DataAnalysizeWindow.Top = this.Top;
            DataAnalysizeWindow.Show();
            this.Close();
        }
    }
}
