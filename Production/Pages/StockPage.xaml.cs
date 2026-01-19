using System.Data.Entity;
using System.Linq;
using System.Windows.Controls;
using Production.Model;

namespace Production.Pages
{
    public partial class StockPage : Page
    {
        ProductionManagementEntities db = new ProductionManagementEntities();

        public StockPage()
        {
            InitializeComponent();
            LoadStock();
        }

        private void LoadStock()
        {
            StockGrid.ItemsSource = db.MaterialStocks
                .Include(s => s.Materials)
                .Include(s => s.Materials.Units)
                .ToList();
        }
    }
}