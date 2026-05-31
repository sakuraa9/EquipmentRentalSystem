using System;
using System.Windows.Forms;

namespace EquipmentRentalSystem
{
    public partial class UserEditForm : Form
    {
        private readonly int _userId;

        public UserEditForm(int userId)
        {
            InitializeComponent();
            this.Text = "Редактирование пользователя";
            _userId = userId;

            LoadUserData();
        }

        private void LoadUserData()
        {
            // Заглушка - позже будем загружать реальные данные
            txtId.Text = _userId.ToString();

            // Пример заполнения (можно потом убрать)
            if (_userId == 1)
            {
                txtLogin.Text = "admin";
                txtFullName.Text = "Администратор";
                cmbRole.SelectedItem = "admin";
                cmbStatus.SelectedItem = "Активен";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Заполните Логин и ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Данные пользователя ID {_userId} успешно обновлены!\n(реальное сохранение позже)",
                           "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}