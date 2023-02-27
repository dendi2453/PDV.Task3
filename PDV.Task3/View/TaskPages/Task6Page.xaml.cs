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
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (x < Math.Pow(1.2, 3))
                    MessageBox.Show($"y = {1.2 * Math.Pow(Math.Sin(x), 2) + 7.2 * Math.Cos(Math.Exp(x)) * x + 1.2}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x >= Math.Pow(-1.5, 3) && x <= 3.2)
                    MessageBox.Show($"y = {Math.Pow(-1.5 + 3.2 * x, 2) - Math.Sin(-1.5 + Math.Exp(2 * x) * x)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x > 5.5)
                    MessageBox.Show($"y = {Math.Sqrt(x - Math.Sin(5.5 * x + Math.Exp(3)))}", "Системное сообщение",
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