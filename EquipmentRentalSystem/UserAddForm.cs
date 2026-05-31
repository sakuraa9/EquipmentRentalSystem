using System;
using System.Windows.Forms;

namespace EquipmentRentalSystem
{
    public partial class UserAddForm : Form
    {
        public UserAddForm()
        {
            InitializeComponent();
            this.Text = "Добавление пользователя";
            SetupComboBoxes();
        }

        private void SetupComboBoxes()
        {
            cmbRole.Items.AddRange(new string[] { "admin", "operator", "user" });
            cmbRole.SelectedIndex = 0;

            cmbStatus.Items.AddRange(new string[] { "Активен", "Неактивен" });
            cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Заполните Логин и ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Пользователь {txtLogin.Text} успешно добавлен!\n(реальное сохранение в базу позже)",
                           "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}