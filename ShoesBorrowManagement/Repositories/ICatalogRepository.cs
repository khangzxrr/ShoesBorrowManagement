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
        void Update(Catalog catalog);
        Catalog? FindById(long id);
        IList<Catalog> GetAll();
    }
}
