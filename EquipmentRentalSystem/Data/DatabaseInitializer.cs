using EquipmentRentalSystem.Services;
using Microsoft.Data.Sqlite;

namespace EquipmentRentalSystem.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using var connection = new SqliteConnection(AppConfig.ConnectionString);
            connection.Open();

            // === Системные таблицы ===
            Execute(connection, """
                CREATE TABLE IF NOT EXISTS Roles (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE
                );
            """);

            Execute(connection, """
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Login TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    PasswordSalt TEXT NOT NULL,
                    FullName TEXT NOT NULL,
                    RoleId INTEGER NOT NULL,
                    IsActive INTEGER NOT NULL DEFAULT 1,
                    CreatedAt TEXT NOT NULL,
                    FOREIGN KEY (RoleId) REFERENCES Roles(Id)
                );
            """);

            Execute(connection, """
                CREATE TABLE IF NOT EXISTS LoginAttempts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserLogin TEXT NOT NULL,
                    IsSuccess INTEGER NOT NULL,
                    Message TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL
                );
            """);

            // === Таблицы для Проката ===
            Execute(connection, """
                CREATE TABLE IF NOT EXISTS EquipmentTypes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE
                );
            """);

            Execute(connection, """
                CREATE TABLE IF NOT EXISTS Equipment (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    InventoryNumber TEXT NOT NULL UNIQUE,
                    Name TEXT NOT NULL,
                    TypeId INTEGER,
                    RentalPrice REAL NOT NULL,
                    Status TEXT DEFAULT 'Available',
                    Description TEXT,
                    FOREIGN KEY(TypeId) REFERENCES EquipmentTypes(Id)
                );
            """);

            Execute(connection, """
                CREATE TABLE IF NOT EXISTS Clients (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Phone TEXT NOT NULL,
                    Passport TEXT,
                    Address TEXT
                );
            """);

            // === ТАБЛИЦА ДОГОВОРОВ (с колонкой CreatedAt) ===
            Execute(connection, """
                CREATE TABLE IF NOT EXISTS RentalContracts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    EquipmentId INTEGER NOT NULL,
                    ClientId INTEGER NOT NULL,
                    RentalDate TEXT NOT NULL,
                    ReturnDate TEXT NOT NULL,
                    ActualReturnDate TEXT,
                    TotalAmount REAL NOT NULL,
                    Status TEXT NOT NULL DEFAULT 'Active',
                    CreatedAt TEXT NOT NULL DEFAULT '2026-05-30 12:00:00',
                    FOREIGN KEY(EquipmentId) REFERENCES Equipment(Id),
                    FOREIGN KEY(ClientId) REFERENCES Clients(Id)
                );
            """);

            // === Базовые данные ===
            Execute(connection, """
                INSERT OR IGNORE INTO Roles (Id, Name) VALUES (1, 'admin'), (2, 'operator'), (3, 'user');
            """);

            Execute(connection, """
                INSERT OR IGNORE INTO EquipmentTypes (Id, Name)
                VALUES (1, 'Строительное'), (2, 'Событийное'), (3, 'Инструмент');
            """);

            // Тестовые данные
            Execute(connection, """
                INSERT OR IGNORE INTO Clients (FullName, Phone, Passport, Address)
                VALUES
                    ('Иванов Иван Иванович', '+7 (999) 123-45-67', '1234 567890', 'г. Москва'),
                    ('Петрова Анна Сергеевна', '+7 (912) 987-65-43', '9876 543210', 'г. Frankfurt');
            """);

            Execute(connection, """
                INSERT OR IGNORE INTO RentalContracts 
                    (EquipmentId, ClientId, RentalDate, ReturnDate, TotalAmount, Status, CreatedAt)
                VALUES
                    (1, 1, '2026-05-20', '2026-06-05', 127500.00, 'Active', '2026-05-30 12:00:00'),
                    (2, 2, '2026-05-25', '2026-06-10', 187500.00, 'Active', '2026-05-30 12:00:00');
            """);

            // === ТЕСТОВЫЙ АДМИН ===
            Execute(connection, """
                DELETE FROM Users WHERE Login = 'admin';
            """);
            string salt = "test_salt_12345";
            string hash = PasswordHasher.HashPassword("admin123", salt);
            Execute(connection, $"""
                INSERT OR IGNORE INTO Users
                    (Login, PasswordHash, PasswordSalt, FullName, RoleId, IsActive, CreatedAt)
                VALUES ('admin', '{hash}', '{salt}', 'Администратор', 1, 1, '2026-05-29T00:00:00')
            """);
        }

        private static void Execute(SqliteConnection connection, string sql)
        {
            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}