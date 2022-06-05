using ShoesBorrowManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.UIServices
{
    public interface IUIGridview
    {
        void deleteDataFromSelectedRowsOrCells(DataGridView gridview, IServices services);
    }
}
