using ShoesBorrowManagement.Objects;
using ShoesBorrowManagement.Repositories;
using ShoesBorrowManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesBorrowManagement
{
    public partial class CatalogsForm : Form
    {
        private ICatalogServices catalogServices;
        public CatalogsForm()
        {
            InitializeComponent();

            catalogServices = new CatalogServices(new CatalogRepository());

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CatalogsForm_Load(object sender, EventArgs e)
        {

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
            var selectedRows = catalogDataGridView.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var catalog = (Catalog) selectedRow.DataBoundItem;
                catalogServices.Delete(catalog);
            }

            var selectedCatalogFromSelectedCells = new HashSet<Catalog>();
            foreach (DataGridViewCell selectedCell in catalogDataGridView.SelectedCells)
            {
                var catalog = (Catalog)catalogDataGridView.Rows[selectedCell.RowIndex].DataBoundItem;
                selectedCatalogFromSelectedCells.Add(catalog);
            }

            foreach(var catalog in selectedCatalogFromSelectedCells)
            {
                catalogServices.Delete(catalog);
            }

            LoadCatalogsDataToGridview();
        }
    }
}
