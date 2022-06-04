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

        public void Remove(Shoe shoe)
        {
           shoeRepository.Delete(shoe);
        }

        public void Update(Shoe shoe)
        {
            shoeRepository.Update(shoe);
        }
    }
}
