using Production.Model;
using System.Linq;
using System.Windows.Controls;

namespace Production.Pages
{
    public partial class MaterialsPage : Page
    {
        ProductionManagementEntities db = new ProductionManagementEntities();

        public MaterialsPage()
        {
            InitializeComponent();
            LoadMaterials();
        }

        private void LoadMaterials()
        {
            var materials = db.Materials
                              .Include("Units")
                              .ToList();

            DataContext = materials;
        }
    }
}