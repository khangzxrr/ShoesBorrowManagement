using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Services
{
    internal interface IShoeServices
    {
        void Add(string name, string detail, string size, long idCatalog);
        void Remove(Shoe shoe);
        void Update(Shoe shoe);
        IList<Shoe> GetAll();
    }
}
