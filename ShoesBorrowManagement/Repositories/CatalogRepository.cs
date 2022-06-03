using Microsoft.Data.Sqlite;
using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Repositories
{
    internal class CatalogRepository : ICatalogRepository
    {
        private string connectionString = @"Data Source=data.db";
        
        public void Add(Catalog catalog)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();


            using var command = new SqliteCommand("INSERT INTO Catalogs(Name) VALUES (@name)",connection);

            command.Parameters.AddWithValue("@name", catalog.name);
            command.Prepare();

            command.ExecuteNonQuery();

            Console.WriteLine("inserted!");
        }

        public void Delete(Catalog catalog)
        {
            throw new NotImplementedException();
        }

        public IList<Catalog> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Catalog catalog)
        {
            throw new NotImplementedException();
        }
    }
}
