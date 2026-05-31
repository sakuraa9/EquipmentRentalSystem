using System;
using System.Windows.Forms;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Services;

namespace EquipmentRentalSystem
{
    public partial class ContractAddForm : Form
    {
        private readonly ContractService _contractService;

        public ContractAddForm()
        {
            InitializeComponent();
            this.Text = "Новый договор - Прокат оборудования";
            _contractService = new ContractService();

            LoadClientsAndEquipment();
            SetupStatusCombo();
        }

        private void LoadClientsAndEquipment()
        {
            // Пока заглушки (позже можно загрузить из базы)
            cmbClient.Items.AddRange(new string[] { "1 - Иванов И.И.", "2 - Петров С.В.", "3 - Сидорова А.П." });
            cmbEquipment.Items.AddRange(new string[] { "1 - Экскаватор Caterpillar 320", "2 - Автокран Liebherr", "3 - Бульдозер Komatsu" });

            if (cmbClient.Items.Count > 0) cmbClient.SelectedIndex = 0;
            if (cmbEquipment.Items.Count > 0) cmbEquipment.SelectedIndex = 0;
        }

        private void SetupStatusCombo()
        {
            cmbStatus.Items.AddRange(new string[] { "Active", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Укажите сумму!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var contract = new Contract
                {
                    ClientId = 1,           // Пока заглушка (потом берём из cmbClient)
                    EquipmentId = 1,        // Пока заглушка (потом берём из cmbEquipment)
                    RentalDate = dtpStartDate.Value.ToString("yyyy-MM-dd"),
                    ReturnDate = dtpEndDate.Value.ToString("yyyy-MM-dd"),
                    TotalAmount = decimal.Parse(txtAmount.Text),
                    Status = cmbStatus.SelectedItem?.ToString() ?? "Active",
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };

                bool success = _contractService.Add(contract);

                if (success)
                {
                    MessageBox.Show("Договор успешно сохранён в базу!", "Успех",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить договор", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении:\n" + ex.Message, "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}