using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Services
{
    public interface ICatalogServices
    {
        bool Validate(string name);
        void Add(string name);
        void Update(Catalog catalog);
        void Delete(Catalog catalog);
        Catalog FindById(long id);
        IList<Catalog> GetAll();
    }
}
