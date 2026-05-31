using Microsoft.Data.Sqlite;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Data;

namespace EquipmentRentalSystem.Services
{
    public class ContractService
    {
        private readonly string _connectionString;
        private static readonly object _lock = new object(); // Защита от блокировки

        public ContractService()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public List<Contract> GetAll()
        {
            lock (_lock)
            {
                var list = new List<Contract>();

                using var connection = new SqliteConnection(_connectionString);
                connection.Open();

                string query = """
                    SELECT 
                        rc.Id,
                        c.FullName as ClientFullName,
                        e.Name as EquipmentName,
                        rc.RentalDate,
                        rc.ReturnDate,
                        rc.TotalAmount,
                        rc.Status
                    FROM RentalContracts rc
                    JOIN Clients c ON rc.ClientId = c.Id
                    JOIN Equipment e ON rc.EquipmentId = e.Id
                    ORDER BY rc.Id DESC
                """;

                using var command = new SqliteCommand(query, connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Contract
                    {
                        Id = reader.GetInt32(0),
                        ClientFullName = reader.GetString(1),
                        EquipmentName = reader.GetString(2),
                        RentalDate = reader.GetString(3),
                        ReturnDate = reader.GetString(4),
                        TotalAmount = reader.GetDecimal(5),
                        Status = reader.GetString(6)
                    });
                }
                return list;
            }
        }

        public bool Add(Contract contract)
        {
            lock (_lock)
            {
                try
                {
                    using var connection = new SqliteConnection(_connectionString);
                    connection.Open();

                    string query = """
                        INSERT INTO RentalContracts 
                            (EquipmentId, ClientId, RentalDate, ReturnDate, TotalAmount, Status, CreatedAt)
                        VALUES 
                            (@EquipmentId, @ClientId, @RentalDate, @ReturnDate, @TotalAmount, @Status, @CreatedAt)
                    """;

                    using var command = new SqliteCommand(query, connection);

                    command.Parameters.AddWithValue("@EquipmentId", contract.EquipmentId);
                    command.Parameters.AddWithValue("@ClientId", contract.ClientId);
                    command.Parameters.AddWithValue("@RentalDate", contract.RentalDate);
                    command.Parameters.AddWithValue("@ReturnDate", contract.ReturnDate);
                    command.Parameters.AddWithValue("@TotalAmount", contract.TotalAmount);
                    command.Parameters.AddWithValue("@Status", contract.Status);
                    command.Parameters.AddWithValue("@CreatedAt", contract.CreatedAt);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении договора:\n" + ex.Message, "Ошибка",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}