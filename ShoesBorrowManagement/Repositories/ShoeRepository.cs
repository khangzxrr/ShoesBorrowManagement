﻿using Microsoft.Data.Sqlite;
using ShoesBorrowManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Repositories
{
    public class ShoeRepository : IShoeRepository
    {
        private string connectionString;
        public ShoeRepository(string connectionString = @"Data Source=data.db")
        {
            this.connectionString = connectionString;
        }

        public void Add(Shoe shoe)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("INSERT INTO Shoes(Name, Detail, Size, IdCatalog) VALUES (@name, @detail, @size, @idcatalog)", connection);

            command.Parameters.AddWithValue("@name", shoe.name);
            command.Parameters.AddWithValue("@detail", shoe.detail);
            command.Parameters.AddWithValue("@size", shoe.size);
            command.Parameters.AddWithValue("@idcatalog", shoe.idCatalog);

            command.Prepare();
            command.ExecuteNonQuery();
        }

        public void Delete(Shoe shoe)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("DELETE FROM Shoes WHERE Id = @id", connection);

            command.Parameters.AddWithValue("@id", shoe.Id);

            command.ExecuteNonQuery();
        }

        public IList<Shoe> GetAll()
        {
            IList<Shoe> shoeList = new List<Shoe>();

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("SELECT * FROM Shoes", connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = (long)reader[0];
                var name = (string)reader[1];
                var detail = (string)reader[2];
                var size = (string)reader[3];
                var idCatalog = (long)reader[4];

                var shoe = new Shoe(id, name, detail, size, idCatalog);
                shoeList.Add(shoe);
            }

            return shoeList;
        }

        public IList<Shoe> GetAll(long totalEachPage = 5, long pageIndex = 1)
        {
            IList<Shoe> shoeList = new List<Shoe>();

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("SELECT * FROM Shoes LIMIT @limit OFFSET @offset", connection);
            command.Parameters.AddWithValue("@limit", totalEachPage);
            command.Parameters.AddWithValue("@offset", (pageIndex - 1) * totalEachPage);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = (long)reader[0];
                var name = (string)reader[1];
                var detail = (string)reader[2];
                var size = (string)reader[3];
                var idCatalog = (long)reader[4];

                var shoe = new Shoe(id, name, detail, size, idCatalog);
                shoeList.Add(shoe);
            }

            return shoeList;
        }

        public long GetTotalPages(long totalEachPage = 5)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("SELECT COUNT(*) FROM Shoes", connection);
            command.Prepare();

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                var totalShoes = (long)reader[0];

                var totalPages = totalShoes / totalEachPage;

                if (totalShoes % totalEachPage > 0)
                {
                    totalPages += 1;
                } 

                return totalPages;

            }
            
            throw new Exception("Không thể tính số trang!");
        }

        public void Update(Shoe shoe)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand("UPDATE Shoes SET Name = @newname, Detail = @newdetail, Size = @newsize, IdCatalog = @new_id_catalog WHERE Id = @id", connection);

            command.Parameters.AddWithValue("@newname", shoe.name);
            command.Parameters.AddWithValue("@newdetail", shoe.detail);
            command.Parameters.AddWithValue("@newsize", shoe.size);
            command.Parameters.AddWithValue("@new_id_catalog", shoe.idCatalog);
            command.Parameters.AddWithValue("@id", shoe.Id);

            command.Prepare();

            command.ExecuteNonQuery();
        }
    }
}
