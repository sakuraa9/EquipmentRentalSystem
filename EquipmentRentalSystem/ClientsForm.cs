using System;
using System.Windows.Forms;

namespace EquipmentRentalSystem
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            this.Text = "Клиенты - Прокат оборудования";
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            SetupColumns();
            LoadClientsData();
        }

        private void SetupColumns()
        {
            // Создаём колонки только если их ещё нет
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("FullName", "ФИО");
                dataGridView1.Columns.Add("Phone", "Телефон");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("Passport", "Паспорт");

                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].Width = 220;
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[4].Width = 140;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadClientsData()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add(1, "Иванов Иван Иванович", "+7 (999) 123-45-67", "ivanov@mail.ru", "1234 567890");
            dataGridView1.Rows.Add(2, "Петрова Анна Сергеевна", "+7 (999) 987-65-43", "petrova@gmail.com", "9876 543210");
            dataGridView1.Rows.Add(3, "Сидоров Алексей Петрович", "+7 (999) 555-33-22", "sidorov@yandex.ru", "4567 890123");
            dataGridView1.Rows.Add(4, "Кузнецова Мария Александровна", "+7 (999) 111-22-33", "maria.kuz@mail.ru", "6543 210987");
        }

        // ================== КНОПКИ ==================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция добавления клиента будет доступна в следующей версии",
                           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите клиента!", "Предупреждение");
                return;
            }
            MessageBox.Show("Функция редактирования будет доступна позже", "Информация");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите клиента!", "Предупреждение");
                return;
            }
            MessageBox.Show("Функция удаления будет доступна позже", "Информация");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClientsData();
        }
    }
}