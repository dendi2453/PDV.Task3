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
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (x < -Math.Log10(0.2))
                    MessageBox.Show($"y = {0.2 * Math.Pow(Math.Sin(x), 2) + 0.5 * Math.Cos(Math.Exp(0.2 * x) * x)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x >= -Math.Log10(0.15) && x <= 0.2)
                    MessageBox.Show($"y = {Math.Pow(0.15, 0.2) - Math.Pow(Math.Cos(0.15 + Math.Exp(2 * 0.15 * x) * x), 3)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x > 5)
                    MessageBox.Show($"y = {Math.Sqrt(2.5 * Math.Pow(0.9, 3)) + Math.Pow(5 - Math.Exp(2.5 * 0.9 * x) * Math.Pow(x, 2), 6)}", "Системное сообщение",
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
