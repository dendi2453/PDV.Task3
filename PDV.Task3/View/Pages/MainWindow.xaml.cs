using PDV.Task3.Core;
using PDV.Task3.View.TaskPages;
using System.Windows;


namespace PDV.Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
