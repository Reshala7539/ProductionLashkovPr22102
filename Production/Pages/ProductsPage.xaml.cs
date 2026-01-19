using System.Linq;
using System.Windows.Controls;
using Production.Model;
using System.Data.Entity;

namespace Production.Pages
{
    public partial class ProductsPage : Page
    {
        ProductionManagementEntities db = new ProductionManagementEntities();

        public ProductsPage()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductsGrid.ItemsSource = db.Products.ToList();
        }

        private void ProductsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = ProductsGrid.SelectedItem as Products;

            if (product != null)
            {
                var bom = db.BillOfMaterials
                            .Where(b => b.ProductID == product.ProductID)
                            .Include("Materials")
                            .ToList();

                BOMGrid.ItemsSource = bom;
            }
        }
    }
}