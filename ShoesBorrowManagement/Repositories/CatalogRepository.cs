using Microsoft.Data.Sqlite;
using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        private string connectionString;

        public CatalogRepository(string connectionString = @"Data Source=data.db")
        {
            this.connectionString = connectionString;
        }

        public void Add(Catalog catalog)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();


            using var command = new SqliteCommand("INSERT INTO Catalogs(Name) VALUES (@name)",connection);

            command.Parameters.AddWithValue("@name", catalog.name);
            command.Prepare();

            command.ExecuteNonQuery();
        }

        public void Delete(Catalog catalog)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("DELETE FROM Catalogs WHERE Name = @name", connection);

            command.Parameters.AddWithValue("@name", catalog.name);
            command.Prepare();

            command.ExecuteNonQuery();
        }

        public Catalog FindById(long id)
        {
            

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("SELECT * FROM Catalogs WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);

            using var dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                var name = (string)dataReader[1];
                Catalog catalog = new Catalog(id, name);

                return catalog;
            }

            return null;
        }

        public IList<Catalog> GetAll()
        {
            IList<Catalog> catalogs = new List<Catalog>();

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("SELECT * FROM Catalogs", connection);
            using var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var id = (long)dataReader[0];
                var name = (string)dataReader[1];
                Catalog catalog = new Catalog(id, name);

                catalogs.Add(catalog);
            }

            return catalogs;
        }

        public void Update(Catalog catalog)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("UPDATE Catalogs SET Name = @new_name WHERE Id = @id", connection);

            command.Parameters.AddWithValue("@new_name", catalog.name);
            command.Parameters.AddWithValue("@id", catalog.Id);
            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
