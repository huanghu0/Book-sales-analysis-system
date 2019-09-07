using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// AboutUsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class AboutUsWindow1 : Window
    {
       
        public AboutUsWindow1()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 p1 = null;
            if (p1 == null)
            {
                p1 = new Page1();
            }
            change.Content = new Frame()
            { Content = p1 };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 p2 = null;
            if (p2 == null)
            {
                p2 = new Page2();
            }
            change.Content = new Frame()
            { Content = p2 };
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page3 p3 = null;
            if (p3 == null)
            {
                p3 = new Page3();
            }
            change.Content = new Frame()
            { Content = p3 };
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page4 p4 = null;
            if (p4 == null)
            {
                p4 = new Page4();
            }
            change.Content = new Frame()
            { Content = p4 };
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            chooseUserTypeWindow1 chooseUserTypeWindow = new chooseUserTypeWindow1();
            chooseUserTypeWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            chooseUserTypeWindow.Left = this.Left;
            chooseUserTypeWindow.Top = this.Top;
            chooseUserTypeWindow.Show();
            this.Close();
        }
    }
}
