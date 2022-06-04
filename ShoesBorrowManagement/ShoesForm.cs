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

            var shoes = shoeServices.GetAll();

            foreach (DataGridViewRow row in dataGridview.Rows)
            {
                long idCatalog = (long)row.Cells[4].Value;

                var catalog = catalogServices.FindById(idCatalog);

                if (catalog != null)
                {
                    row.Cells[4].Value = catalog.name;
                }
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
            }catch(FormatException ex)
            {
                MessageBox.Show("Vui lòng đảm bảo bạn đã nhập đầy đủ");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void shoeDetailTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
