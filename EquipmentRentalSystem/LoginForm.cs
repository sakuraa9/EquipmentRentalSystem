using EquipmentRentalSystem.Data;
using EquipmentRentalSystem.Services;
using Microsoft.Data.Sqlite;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EquipmentRentalSystem
{
    public partial class LoginForm : Form
    {
        private int loginAttempts = 0;
        private const int MAX_ATTEMPTS = 3;
        private string captchaCode = "";

        public LoginForm()
        {
            InitializeComponent();
            DatabaseInitializer.Initialize();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ23456789";
            var random = new Random();
            captchaCode = new string(Enumerable.Range(0, 5)
                .Select(_ => chars[random.Next(chars.Length)]).ToArray());

            label4.Text = captchaCode;   // Показываем капчу
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e) // Войти
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string captchaInput = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(captchaInput) || captchaInput.ToUpper() != captchaCode)
            {
                MessageBox.Show("Неверный код CAPTCHA!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerateCaptcha();
                return;
            }

            using var connection = new SqliteConnection(AppConfig.ConnectionString);
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = """
                SELECT PasswordHash, PasswordSalt, FullName 
                FROM Users WHERE Login = @login
            """;
            cmd.Parameters.AddWithValue("@login", login);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string hash = reader.GetString(0);
                string salt = reader.GetString(1);

                if (PasswordHasher.Verify(password, salt, hash))
                {
                    MessageBox.Show($"Добро пожаловать, {reader.GetString(2)}!", "Успех");

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                    return;
                }
            }

            // Неудачная попытка
            loginAttempts++;
            MessageBox.Show("Неверный логин или пароль!", "Ошибка");

            GenerateCaptcha();

            if (loginAttempts >= MAX_ATTEMPTS)
            {
                MessageBox.Show("Слишком много попыток входа!\nПриложение закрывается.", "Блокировка");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Регистрация
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // Выход
        {
            Application.Exit();
        }
    }
}