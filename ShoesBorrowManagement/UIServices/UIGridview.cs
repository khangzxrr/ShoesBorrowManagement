using ShoesBorrowManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.UIServices
{
    public class UIGridview : IUIGridview
    {
        public void deleteDataFromSelectedRowsOrCells(DataGridView gridview, IServices services)
        {
            foreach (DataGridViewRow selectedRow in gridview.SelectedRows)
            {
                var obj = selectedRow.DataBoundItem;

                services.Delete(obj);
            }

            var deletingRows = new HashSet<int>();
            foreach (DataGridViewCell selectedCell in gridview.SelectedCells)
            {
                deletingRows.Add(selectedCell.RowIndex);
            }

            foreach (var row in deletingRows)
            {
                var obj = gridview.Rows[row].DataBoundItem;
                services.Delete(obj);
            }
        }

   
    }
}
