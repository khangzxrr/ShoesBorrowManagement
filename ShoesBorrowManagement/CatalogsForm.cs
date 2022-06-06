using ShoesBorrowManagement.Objects;
using ShoesBorrowManagement.Repositories;
using ShoesBorrowManagement.Services;
using ShoesBorrowManagement.UIServices;

namespace ShoesBorrowManagement
{
    public partial class CatalogsForm : Form
    {
        private ICatalogServices catalogServices;
        private IUIGridview UIgridview;
        public CatalogsForm()
        {
            InitializeComponent();

            catalogServices = new CatalogServices(new CatalogRepository());
            UIgridview = new UIGridview();

            LoadCatalogsDataToGridview();
        }

        public void LoadCatalogsDataToGridview()
        {
            var catalogs = catalogServices.GetAll();
            catalogDataGridView.DataSource = catalogs;

            catalogDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            catalogDataGridView.Columns[0].ReadOnly = true;

            catalogDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                catalogServices.Add(catalogName.Text);
                LoadCatalogsDataToGridview();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                errorProvider.SetError(catalogName, "Có lỗi");
                MessageBox.Show("vui lòng đảm bảo loại giày không bị trùng khớp hoặc để trống");

            }
            
        }

        private void dataGridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editedCatalog = (Catalog) catalogDataGridView.Rows[e.RowIndex].DataBoundItem;
            catalogServices.Update(editedCatalog);

        }

        private void dataGridview_cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim())) 
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
                e.Cancel = true;
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UIgridview.deleteDataFromSelectedRowsOrCells(catalogDataGridView, catalogServices);

            LoadCatalogsDataToGridview();
        }
    }
}
