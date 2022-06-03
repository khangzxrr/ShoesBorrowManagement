using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Objects
{
    public class Shoe
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string detail { get; set; }
        public string size { get; set; }
        public long idCatalog { get; set; }

        public Shoe(long id, string name, string detail, string size, long idCatalog)
        {
            this.Id = id;
            this.name = name;
            this.detail = detail;
            this.size = size;
            this.idCatalog = idCatalog;
        }

    }
}
