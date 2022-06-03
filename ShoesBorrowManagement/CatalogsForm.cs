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
        }




        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                catalogServices.Add(catalogName.Text);
                MessageBox.Show("Thêm thành công!");

                Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                errorProvider.SetError(catalogName, "Có lỗi");
                MessageBox.Show("vui lòng đảm bảo loại giày không bị trùng khớp hoặc để trống");

            }
            

        }
    }
}
