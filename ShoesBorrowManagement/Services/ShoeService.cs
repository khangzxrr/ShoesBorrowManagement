using ShoesBorrowManagement.Objects;
using ShoesBorrowManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Services
{
    internal class ShoeService : IShoeServices
    {
        private IShoeRepository shoeRepository;
        public ShoeService(IShoeRepository shoeRepository)
        {
            this.shoeRepository = shoeRepository;
        }
        public void Add(string name, string detail, string size, long idCatalog)
        {
            Shoe shoe = new Shoe(name, detail, size, idCatalog);
            shoeRepository.Add(shoe);
        }

        public IList<Shoe> GetAll()
        {
            return shoeRepository.GetAll();
        }

        public IList<BorrowedShoe> GetAllBorrowedShoes()
        {
            return shoeRepository.GetAllBorrowShoe();
        }

        public Shoe? GetShoeById(long id)
        {
            return shoeRepository.GetShoeById(id);
        }

        public IList<UnBorrowedShoe> GetUnBorrowedShoes()
        {
            return shoeRepository.GetNotBorrowShoe();
        }

        public void Delete(Shoe shoe)
        {
           shoeRepository.Delete(shoe);
        }

        public void Update(Shoe shoe)
        {
            shoeRepository.Update(shoe);
        }

        public void Delete(BorrowedShoe shoe)
        {
            shoeRepository.Delete(shoe);
        }

        public void Delete(object obj)
        {
            if (obj is Shoe)
            {
                var shoe = (Shoe)obj;
                Delete(shoe);
            }
            else if (obj is BorrowedShoe)
            {
                var shoe = (BorrowedShoe)obj;
                Delete(shoe);
            }
        }

        public void BorrowingShoes(IList<UnBorrowedShoe> shoeList, DateTime date)
        {
            foreach(var shoe in shoeList)
            {
                BorrowedShoe borrowedShoe = new BorrowedShoe(shoe.ID, shoe.name, date);
                shoeRepository.Add(borrowedShoe);
            }

            
        }
    }
}
