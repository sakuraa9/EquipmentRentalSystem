using Microsoft.Data.Sqlite;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Data;

namespace EquipmentRentalSystem.Services
{
    public class EquipmentService
    {
        private readonly string _connectionString;
        private static readonly object _lock = new object();

        public EquipmentService()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public List<Equipment> GetAll()
        {
            lock (_lock)
            {
                var list = new List<Equipment>();

                using var connection = new SqliteConnection(_connectionString);
                connection.Open();

                string query = """
                    SELECT Id, InventoryNumber, Name, TypeId, RentalPrice,
                           Status, Description
                    FROM Equipment
                    ORDER BY Id
                """;

                using var command = new SqliteCommand(query, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Equipment
                    {
                        Id = reader.GetInt32(0),
                        InventoryNumber = reader.GetString(1),
                        Name = reader.GetString(2),
                        TypeId = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                        RentalPrice = reader.GetDecimal(4),
                        Status = reader.GetString(5),
                        Description = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    });
                }
                return list;
            }
        }

        public bool Add(Equipment equipment)
        {
            lock (_lock)
            {
                using var connection = new SqliteConnection(_connectionString);
                connection.Open();

                string query = """
                    INSERT INTO Equipment
                        (InventoryNumber, Name, TypeId, RentalPrice, Status, Description)
                    VALUES
                        (@InventoryNumber, @Name, @TypeId, @RentalPrice, @Status, @Description)
                """;

                using var command = new SqliteCommand(query, connection);

                command.Parameters.AddWithValue("@InventoryNumber", equipment.InventoryNumber);
                command.Parameters.AddWithValue("@Name", equipment.Name);
                command.Parameters.AddWithValue("@TypeId", equipment.TypeId.HasValue ? equipment.TypeId.Value : DBNull.Value);
                command.Parameters.AddWithValue("@RentalPrice", equipment.RentalPrice);
                command.Parameters.AddWithValue("@Status", equipment.Status);
                command.Parameters.AddWithValue("@Description", equipment.Description ?? "");

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Delete(int id)
        {
            lock (_lock)
            {
                using var connection = new SqliteConnection(_connectionString);
                connection.Open();

                string query = "DELETE FROM Equipment WHERE Id = @Id";

                using var command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}