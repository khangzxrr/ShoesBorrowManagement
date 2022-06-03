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
        IList<Catalog> GetAll();
    }
}
