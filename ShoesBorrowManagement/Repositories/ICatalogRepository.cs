using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Repositories
{
     public interface ICatalogRepository
    {
        void Add(Catalog catalog);
        void Delete(Catalog catalog);
        IList<Catalog> GetAll();
    }
}
