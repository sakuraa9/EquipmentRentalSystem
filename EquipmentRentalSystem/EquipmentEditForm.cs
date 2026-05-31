using System;
using System.Windows.Forms;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Services;

namespace EquipmentRentalSystem
{
    public partial class EquipmentEditForm : Form
    {
        private readonly EquipmentService _equipmentService;
        private readonly int _equipmentId;

        public EquipmentEditForm(int equipmentId)
        {
            InitializeComponent();
            this.Text = "Редактирование оборудования";
            _equipmentService = new EquipmentService();
            _equipmentId = equipmentId;

            LoadEquipmentData();
        }

        private void LoadEquipmentData()
        {
            // Пока заглушка
            txtId.Text = _equipmentId.ToString();
            // Здесь позже будем загружать реальные данные из базы
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Изменения для оборудования ID {_equipmentId} успешно сохранены!\n\n(реальное обновление базы будет позже)",
                           "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}