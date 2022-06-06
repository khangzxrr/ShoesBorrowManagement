using ShoesBorrowManagement.Objects;
using ShoesBorrowManagement.Repositories;
using ShoesBorrowManagement.Services;
using ShoesBorrowManagement.UIServices;
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
    public partial class BorrowForm : Form
    {
        private IShoeServices shoeServices;
        private ICatalogServices catalogServices;

        private IUIGridview UIgridview;

        public BorrowForm()
        {
            InitializeComponent();

            shoeServices = new ShoeService(new ShoeRepository());
            catalogServices = new CatalogServices(new CatalogRepository());

            UIgridview = new UIGridview();

            LoadData();
        }

        private void LoadData()
        {
            IList<BorrowedShoe> borrowedShoes = shoeServices.GetAllBorrowedShoes();
            borrowGrid.DataSource = borrowedShoes;

            borrowGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            borrowGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (borrowedShoes.Count > 0)
            {
                fetchAndDisplayDetails(borrowedShoes.First());
            }


            IList<UnBorrowedShoe> unBorrowedShoes = shoeServices.GetUnBorrowedShoes();
            unborrowedDatagrid.DataSource = unBorrowedShoes;

            unborrowedDatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            unborrowedDatagrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void borrowShoeBtn_Click(object sender, EventArgs e)
        {
            if (unborrowedDatagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giày");
                return;
            }

            IList<UnBorrowedShoe> borrowingShoes = new List<UnBorrowedShoe>();

            foreach (DataGridViewRow row in unborrowedDatagrid.SelectedRows)
            {
                var shoe = (UnBorrowedShoe)row.DataBoundItem;
                borrowingShoes.Add(shoe);
            }

            ConfirmBorrow confirmBorrow = new ConfirmBorrow(shoeServices, borrowingShoes); 
            confirmBorrow.ShowDialog();

            confirmBorrow.Close();

            LoadData();
        }

        private void borrowGrid_onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var  borrowShoe = (BorrowedShoe)borrowGrid.Rows[e.RowIndex].DataBoundItem;
            fetchAndDisplayDetails(borrowShoe);
        }


        private void fetchAndDisplayDetails(BorrowedShoe borrowedShoe)
        {
            Shoe? shoe = shoeServices.GetShoeById(borrowedShoe.idShoe);

            if (shoe == null)
            {
                MessageBox.Show("Giày không tồn tại?");
                LoadData();

                return;
            }

            Catalog catalog = catalogServices.FindById(shoe.idCatalog);

            setShoeDetails(shoe.name, catalog.name, shoe.size, shoe.detail, borrowedShoe.date);
        }
        private void setShoeDetails(
            string name = "", 
            string catalog = "", 
            string size = "", 
            string detail = "", 
            DateTime? borrowDate = null)
        {
            shoeName.Text = String.Format($"Tên: {name}");
            shoeCatalog.Text = String.Format($"Loại: {catalog}");
            shoeSize.Text = String.Format($"Size: {size}");
            shoeDetail.Text = String.Format($"Chi tiết: {detail}");

            if (borrowDate != null)
            {
                shoeBorrowDate.Text = String.Format($"Ngày mượn: {borrowDate}");

                TimeSpan totalDate = ((TimeSpan)(DateTime.Now - borrowDate));

                if (totalDate.Days < 0 || totalDate.Hours < 0)
                {
                    showBorrowDateCount.Text = String.Format($"Thời gian mượn ở tương lai");
                }
                else
                {
                    showBorrowDateCount.Text = String.Format($"Đã mượn: {totalDate.Days} ngày {totalDate.Hours} giờ");
                }


                return;
            }

            shoeBorrowDate.Text = String.Format($"Ngày mượn: ");
            showBorrowDateCount.Text = String.Format($"Đã mượn: ");
        }

        private void deleteBorrowButton_Click(object sender, EventArgs e)
        {
            UIgridview.deleteDataFromSelectedRowsOrCells(borrowGrid, shoeServices);

            LoadData();
        }

        private void managed_shoe(object sender, EventArgs e)
        {
            try
            {
                var form = new ShoesForm();
                form.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLiên hệ Developer ngay!");
            }
            LoadData();
        }

        private void managed_catalog(object sender, EventArgs e)
        {
            try
            {
                var form = new CatalogsForm();
                form.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLiên hệ Developer ngay!");
            }
            LoadData();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
