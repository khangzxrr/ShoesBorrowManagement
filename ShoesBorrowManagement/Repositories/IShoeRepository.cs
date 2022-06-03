using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Repositories
{
    public interface IShoeRepository
    {
        void Add(Shoe shoe);
        void Delete(Shoe shoe);
        void Update(Shoe shoe);
        IList<Shoe> GetAll();
        IList<Shoe> GetAll(long totalEachPage = 5, long pageIndex = 1);
        long GetTotalPages(long totalEachPage = 5);

    }
}
