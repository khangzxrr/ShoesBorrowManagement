using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Objects
{
    public class Catalog
    {
        public int Id { get; set; }
        public string name { get; set; }

        public Catalog(string name)
        {
            this.name = name;
        }
        public Catalog(int Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }
    }
}
