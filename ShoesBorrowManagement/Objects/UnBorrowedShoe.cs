using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Objects
{
    public class UnBorrowedShoe
    {

        [DisplayName("ID")]
        [Browsable(false)]
        public long ID { get; set; }
        [DisplayName("Tên giày")]
        public string name { get; set; }
        [DisplayName("Size")]
        public string size { get; set; }
        [DisplayName("Chi tiết")]
        public string detail { get; set; }

        public UnBorrowedShoe(long id, string name, string detail, string size)
        {
            ID = id;
            this.name = name;
            this.detail = detail;
            this.size = size;
        }

        

    }
}
