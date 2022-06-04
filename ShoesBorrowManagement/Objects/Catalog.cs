using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Objects
{
    public class Catalog
    {
        [DisplayName("ID")]
        public long Id { get; set; }
        [DisplayName("Tên loại giày")]
        public string name { get; set; }

        public Catalog(string name)
        {
            this.name = name;
        }
        public Catalog(long Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }
    }
}
