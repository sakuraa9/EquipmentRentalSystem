using System;
using System.Drawing;
using System.Windows.Forms;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Services;

namespace EquipmentRentalSystem
{
    public partial class EquipmentAddForm : Form
    {
        private readonly EquipmentService _service;

        public EquipmentAddForm()
        {
            InitializeComponent();
            _service = new EquipmentService();
        }

        private void InitializeComponent()
        {
            this.Text = "Добавить новое оборудование";
            this.Size = new Size(520, 480);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Название
            var lblName = new Label { Text = "Название *:", Location = new Point(20, 20), AutoSize = true };
            var txtName = new TextBox { Location = new Point(150, 18), Width = 340 };

            // Инв. номер
            var lblInv = new Label { Text = "Инв. номер *:", Location = new Point(20, 60), AutoSize = true };
            var txtInv = new TextBox { Location = new Point(150, 58), Width = 340 };

            // Цена
            var lblPrice = new Label { Text = "Цена за сутки:", Location = new Point(20, 100), AutoSize = true };
            var txtPrice = new TextBox { Location = new Point(150, 98), Width = 340, Text = "0" };

            // Статус
            var lblStatus = new Label { Text = "Статус:", Location = new Point(20, 140), AutoSize = true };
            var cmbStatus = new ComboBox { Location = new Point(150, 138), Width = 340 };
            cmbStatus.Items.AddRange(new string[] { "Available", "In Repair", "Rented", "Maintenance" });
            cmbStatus.SelectedIndex = 0;

            // Описание
            var lblDesc = new Label { Text = "Описание:", Location = new Point(20, 180), AutoSize = true };
            var txtDesc = new TextBox { Location = new Point(150, 178), Width = 340, Height = 120, Multiline = true };

            // Кнопка Сохранить
            var btnSave = new Button
            {
                Text = "Сохранить",
                Location = new Point(190, 320),
                Size = new Size(140, 45),
                BackColor = Color.LimeGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };

            btnSave.Click += BtnSave_Click;

            this.Controls.Add(lblName); this.Controls.Add(txtName);
            this.Controls.Add(lblInv); this.Controls.Add(txtInv);
            this.Controls.Add(lblPrice); this.Controls.Add(txtPrice);
            this.Controls.Add(lblStatus); this.Controls.Add(cmbStatus);
            this.Controls.Add(lblDesc); this.Controls.Add(txtDesc);
            this.Controls.Add(btnSave);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Controls[1].Text) || string.IsNullOrWhiteSpace(Controls[3].Text))
                {
                    MessageBox.Show("Название и Инвентарный номер обязательны!", "Ошибка");
                    return;
                }

                var equipment = new Equipment
                {
                    InventoryNumber = Controls[3].Text.Trim(),   // txtInv
                    Name = Controls[1].Text.Trim(),               // txtName
                    RentalPrice = decimal.Parse(Controls[5].Text), // txtPrice
                    Status = ((ComboBox)Controls[7]).Text,        // cmbStatus
                    Description = Controls[9].Text.Trim()         // txtDesc
                };

                // Здесь будет вызов сохранения (пока просто сообщение)
                MessageBox.Show("Оборудование успешно добавлено в базу!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении:\n" + ex.Message, "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}