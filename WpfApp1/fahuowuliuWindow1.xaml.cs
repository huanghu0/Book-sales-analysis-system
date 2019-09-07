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
    /// fahuowuliuWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class fahuowuliuWindow1 : Window
    {
        public fahuowuliuWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WuliugenzongWindow1 WuliugenzongWindow = new WuliugenzongWindow1();
            WuliugenzongWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            WuliugenzongWindow.Left = this.Left;
            WuliugenzongWindow.Top = this.Top;
            WuliugenzongWindow.Show();
            this.Close();
        }
    }
}
