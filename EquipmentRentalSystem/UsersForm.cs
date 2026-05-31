using System;
using System.Windows.Forms;

namespace EquipmentRentalSystem
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            this.Text = "Пользователи - Прокат оборудования";
            SetupColumns();
        }

        private void SetupColumns()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("FullName", "ФИО");
            dataGridView1.Columns.Add("Role", "Роль");
            dataGridView1.Columns.Add("Status", "Статус");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(1, "admin", "Администратор", "admin", "Активен");
            dataGridView1.Rows.Add(2, "operator1", "Иванов Иван Иванович", "operator", "Активен");
            dataGridView1.Rows.Add(3, "user1", "Петров Сергей", "user", "Неактивен");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция добавления пользователя будет доступна в следующей версии", "Информация");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите пользователя для редактирования", "Предупреждение");
                return;
            }
            MessageBox.Show("Функция редактирования пользователя будет доступна в следующей версии", "Информация");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите пользователя для удаления", "Предупреждение");
                return;
            }
            MessageBox.Show("Функция удаления пользователя будет доступна в следующей версии", "Информация");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsersData();
        }
    }
}