using System.Windows;
using Production.Pages;

namespace Production
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MaterialsPage());
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MaterialsPage());
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }

        private void Purchases_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PurchasesPage());
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StockPage());
        }
        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductionOrdersPage());
        }
        private void EmployeesEquipment_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmployeesEquipmentPage());
        }
    }
}