using Microsoft.Data.Sqlite;
using NUnit.Framework;
using ShoesBorrowManagement.Repositories;
using ShoesBorrowManagement.Services;
using System;

namespace ShoesBorrowTesting
{
    public class CatalogTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Catalog_not_allow_duplication_exception_test()
        {
            ICatalogRepository catalogRepository = new CatalogRepository("Data Source=test.db");
            ICatalogServices catalogService = new CatalogServices(catalogRepository);

            catalogService.Add("duplicationCatalog");

            Assert.Throws<SqliteException>(() => catalogService.Add("duplicationCatalog"));
        }

        [Test]
        public void Catalog_not_empty_exception_test()
        {
            ICatalogRepository catalogRepository = new CatalogRepository("Data Source=test.db");
            ICatalogServices catalogService = new CatalogServices(catalogRepository);

            Assert.Throws<ArgumentException>(() => catalogService.Add(""));
        }

        [Test]
        public void Catalog_read_all_test()
        {
            ICatalogRepository catalogRepository = new CatalogRepository("Data Source=test.db");
            ICatalogServices catalogService = new CatalogServices(catalogRepository);

            Assert.IsTrue(catalogService.GetAll().Count > 0);
        }
    }
}