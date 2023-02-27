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
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (Math.Pow(x, 2) > 5.15 + -1.15)
                    MessageBox.Show($"y = {Math.Log10(Math.Abs(5.15 * x + -1.15))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (Math.Pow(x, 2) == -2.4 + 4.36)
                    MessageBox.Show($"y = {Math.Exp(Math.Cos(Math.Abs(-2.4 * x - 4.36)))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (Math.Pow(x, 2) < 0.8 + 0.41)
                    MessageBox.Show($"y = {Math.Sqrt(Math.Pow(1.1, 2) + Math.Pow(Math.Cos(x), 2))}", "Системное сообщение",
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
