using ShoesBorrowManagement.Objects;
using ShoesBorrowManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Services
{
    public class CatalogServices : ICatalogServices
    {
        private ICatalogRepository catalogRepository;

        public CatalogServices(ICatalogRepository catalogRepository)
        {
            this.catalogRepository = catalogRepository;
        }
        public bool Validate(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Vui lòng nhập dữ liệu");
            }

            return true;
        }

        
        public void Add(string name)
        {
            Validate(name);

            Catalog catalog = new Catalog(name);

            catalogRepository.Add(catalog);
        }

        public IList<Catalog> GetAll()
        {
            return catalogRepository.GetAll();
        }

        public void Update(Catalog catalog)
        {
            catalogRepository.Update(catalog);
        }

        public void Delete(Catalog catalog)
        {
            catalogRepository.Delete(catalog);
        }

        public Catalog FindById(long id)
        {
            return catalogRepository.FindById(id);
        }
    }
}
