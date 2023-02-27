using PDV.Task3.Core;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PDV.Task3.View.TaskPages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (Math.Exp(x) < Math.Exp(4.3 + 5.3))
                    MessageBox.Show($"y = {Math.Sin(Math.Exp(4.3 + 5.3) + Math.Pow(x, 2))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (Math.Exp(4.3 + 5.3) == Math.Exp(x))
                    MessageBox.Show($"y = {Math.Atan(-0.35 * 1.8 * -1.8) + Math.Sqrt(x)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (Math.Exp(x) > Math.Exp(4.3 + 5.3))
                    MessageBox.Show($"y = {Math.Cos(Math.Sqrt(Math.Abs(x + -0.35 * 1.8 * -1.8)))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else MessageBox.Show("Не удовлетворяет условию функции", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                TbX.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
    }
}
