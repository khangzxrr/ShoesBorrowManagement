using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Services
{
    public interface IShoeServices : IServices
    {
        void Add(string name, string detail, string size, long idCatalog);
        void BorrowingShoes(IList<UnBorrowedShoe> shoeList, DateTime date, string note);
        void Delete(Shoe shoe);
        void Delete(BorrowedShoe shoe);
        void Update(Shoe shoe);
        IList<Shoe> GetAll();
        IList<BorrowedShoe> GetAllBorrowedShoes();
        IList<UnBorrowedShoe> GetUnBorrowedShoes();
        Shoe? GetShoeById(long id);
    }
}
