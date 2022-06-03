using NUnit.Framework;
using ShoesBorrowManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowTesting
{
    public class ShoeTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void shoe_get_total_pages_test()
        {
            IShoeRepository shoeRepository = new ShoeRepository("Data Source=test.db");
            long totalPages = shoeRepository.GetTotalPages(5);  //13 totals / 5 = 3 pages

            Assert.AreEqual(3, totalPages);
        }

        [Test]
        public void shoe_get_last_page_element_count_test()
        {
            IShoeRepository shoeRepository = new ShoeRepository("Data Source=test.db");
            long totalPages = shoeRepository.GetTotalPages(5);  //13 totals / 5 = 3 pages

            var shoes = shoeRepository.GetAll(5, totalPages); //get last page (3)

            Assert.AreEqual(3, shoes.Count);
        }

        [Test]
        public void cascade_catalog_shoe_delete_test()
        {
            ICatalogRepository catalogRepository = new CatalogRepository("Data Source=test_delete_cataog.db");

            var catalogs = catalogRepository.GetAll();

            catalogRepository.Delete(catalogs[0]); //delete catalog with id = 1

            IShoeRepository shoeRepository = new ShoeRepository("Data Source=test_delete_cataog.db");

            var shoes = shoeRepository.GetAll(); //0 because all of them has IdCatalog = 1

            Assert.AreEqual(0, shoes.Count);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
