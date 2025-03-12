using System;
using System.Threading.Tasks;
using System.Windows;

namespace P4_Async
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            StatusLabel.Content = "Processing order... ";
            await ProcessOrder();

            StatusLabel.Content = $"Your order for '{OrderName.Text}' is ready!";
            OrderName.Clear();
        }

        private async Task ProcessOrder()
        {
            await Task.Delay(3000);
        }
    }
}
