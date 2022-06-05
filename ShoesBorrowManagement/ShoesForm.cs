using Microsoft.Data.Sqlite;
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
    public partial class ShoesForm : Form
    {
        private IShoeServices shoeServices;
        private ICatalogServices catalogServices;
        public ShoesForm()
        {
            InitializeComponent();

            

            shoeServices = new ShoeService(new ShoeRepository());
            catalogServices = new CatalogServices(new CatalogRepository());

            LoadData();
        }

        public void LoadData()
        {
            var catalogs = catalogServices.GetAll();
            catalogCombobox.DataSource = catalogs;

            catalogCombobox.DisplayMember = "Name";
            catalogCombobox.ValueMember = "Id";

            DataGridViewComboBoxColumn cbColumn = (DataGridViewComboBoxColumn)dataGridview.Columns["Catalog"];
            cbColumn.DataSource = catalogs;

            cbColumn.DisplayMember = "Name";
            cbColumn.ValueMember = "Id";


            var shoes = shoeServices.GetAll();

            dataGridview.Rows.Clear();

            foreach (var shoe in shoes)
            {   
                dataGridview.Rows.Add(new object[] { 
                    shoe.Id, shoe.name, shoe.size, shoe.detail,
                    shoe.idCatalog
                });
            }


        }

        private void ShoesForm_Load(object sender, EventArgs e)
        {

        }

        private void addShoeButton_Click(object sender, EventArgs e)
        {
            try
            {
                shoeServices.Add(shoeNameTextbox.Text,
                    shoeDetailTextbox.Text,
                    shoeSizeTextbox.Text,
                    (long)catalogCombobox.SelectedValue);

                LoadData();
            } catch (FormatException)
            {
                MessageBox.Show("Vui lòng đảm bảo bạn đã nhập đầy đủ");
            }
            catch(SqliteException)
            {
                MessageBox.Show("Vui lòng đảm bảo tên không bị trùng");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void shoeDetailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private Shoe getShoeFromRowIndex(int rowIndex)
        {
            var id = (long)dataGridview.Rows[rowIndex].Cells[0].Value;
            var name = (string)dataGridview.Rows[rowIndex].Cells[1].Value;
            var size = (string)dataGridview.Rows[rowIndex].Cells[2].Value;
            var detail = (string)dataGridview.Rows[rowIndex].Cells[3].Value;
            var idCatalog = (long)dataGridview.Rows[rowIndex].Cells[4].Value;

            Shoe shoe = new Shoe(id, name, detail, size, idCatalog);

            return shoe;
        }

        private void datagrid_cell_end_edit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var shoe = getShoeFromRowIndex(e.RowIndex);

                shoeServices.Update(shoe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void datagrid_cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 && string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                MessageBox.Show("Vui lòng nhập tên giày");
                e.Cancel = true;
            }
        }

        private void deleteShoe_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridview.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                var shoe = getShoeFromRowIndex(selectedRow.Index);

                shoeServices.Delete(shoe);
            }

            var deletingRows = new HashSet<int>();
            foreach (DataGridViewCell selectedCell in dataGridview.SelectedCells)
            {
                deletingRows.Add(selectedCell.RowIndex);
            }

            foreach(int rowIndex in deletingRows)
            {
                var shoe = getShoeFromRowIndex(rowIndex);
                shoeServices.Delete(shoe);
            }

            LoadData();
        }

        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
