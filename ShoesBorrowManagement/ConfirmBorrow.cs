using ShoesBorrowManagement.Objects;
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
    public partial class ConfirmBorrow : Form
    {
        private IShoeServices shoeServices;
        private IList<UnBorrowedShoe> borrowingShoes;
        public ConfirmBorrow(IShoeServices shoeService, IList<UnBorrowedShoe> borrowingShoes)
        {
            InitializeComponent();

            this.shoeServices = shoeService;    
            this.borrowingShoes = borrowingShoes;

            loadData();
        }

        private void loadData()
        {
            confirmLabel.Text = $"Xác nhận cho mượn\n{borrowingShoes.Count} giày vào ngày";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            shoeServices.BorrowingShoes(borrowingShoes, borrowDate.Value, borrowNote.Text);

            Close();
        }
    }
}
