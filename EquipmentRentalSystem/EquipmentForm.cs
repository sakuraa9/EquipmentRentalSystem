using System;
using System.Drawing;
using System.Windows.Forms;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Services;
namespace EquipmentRentalSystem
{
    public partial class Оборудование : Form
    {
        private readonly EquipmentService _equipmentService;
        public Оборудование()
        {
            InitializeComponent();
            this.Text = "Оборудование - Прокат";
            _equipmentService = new EquipmentService();
        }
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            Col_EquipmentID = new DataGridViewTextBoxColumn();
            Col_Name = new DataGridViewTextBoxColumn();
            Col_Type = new DataGridViewTextBoxColumn();
            Col_SerialNumber = new DataGridViewTextBoxColumn();
            Col_CostPerDay = new DataGridViewTextBoxColumn();
            Col_Status = new DataGridViewTextBoxColumn();
            Col_Description = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // btnAdd
            //
            btnAdd.Location = new Point(20, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 35);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Добавить";
            btnAdd.Click += btnAdd_Click;
            //
            // btnEdit
            //
            btnEdit.Location = new Point(170, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 35);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Редактировать";
            btnEdit.Click += btnEdit_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(320, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.LimeGreen;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(450, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(587, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 35);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Поиск";
            btnSearch.Click += btnSearch_Click;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_EquipmentID, Col_Name, Col_Type, Col_SerialNumber, Col_CostPerDay, Col_Status, Col_Description });
            dataGridView1.Location = new Point(0, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(981, 533);
            dataGridView1.TabIndex = 5;
            //
            // Col_EquipmentID
            //
            Col_EquipmentID.HeaderText = "ID";
            Col_EquipmentID.Name = "Col_EquipmentID";
            Col_EquipmentID.ReadOnly = true;
            //
            // Col_Name
            //
            Col_Name.HeaderText = "Название";
            Col_Name.Name = "Col_Name";
            Col_Name.ReadOnly = true;
            //
            // Col_Type
            //
            Col_Type.HeaderText = "Инв. номер";
            Col_Type.Name = "Col_Type";
            Col_Type.ReadOnly = true;
            //
            // Col_SerialNumber
            //
            Col_SerialNumber.HeaderText = "Серийный номер";
            Col_SerialNumber.Name = "Col_SerialNumber";
            Col_SerialNumber.ReadOnly = true;
            //
            // Col_CostPerDay
            //
            dataGridViewCellStyle2.Format = "N2";
            Col_CostPerDay.DefaultCellStyle = dataGridViewCellStyle2;
            Col_CostPerDay.HeaderText = "Цена за сутки";
            Col_CostPerDay.Name = "Col_CostPerDay";
            Col_CostPerDay.ReadOnly = true;
            //
            // Col_Status
            //
            Col_Status.HeaderText = "Статус";
            Col_Status.Name = "Col_Status";
            Col_Status.ReadOnly = true;
            //
            // Col_Description
            //
            Col_Description.HeaderText = "Описание";
            Col_Description.Name = "Col_Description";
            Col_Description.ReadOnly = true;
            //
            // txtSearch
            //
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(703, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 25);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // Оборудование
            //
            ClientSize = new Size(984, 611);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Оборудование";
            Text = "Оборудование — Прокат";
            Load += Оборудование_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private void Оборудование_Load(object sender, EventArgs e)
        {
            LoadEquipmentData();
        }
        private void LoadEquipmentData()
        {
            try
            {
                var equipmentList = _equipmentService.GetAll();
                dataGridView1.Rows.Clear();
                foreach (var eq in equipmentList)
                {
                    dataGridView1.Rows.Add(
                    eq.Id,
                    eq.Name,
                    eq.InventoryNumber,
                    eq.InventoryNumber,
                    eq.RentalPrice,
                    eq.Status,
                    eq.Description
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки:\n" + ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ================== ОБРАБОТЧИКИ КНОПОК ==================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new EquipmentAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEquipmentData();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите строку для удаления!", "Предупреждение",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? "";
            var confirm = MessageBox.Show($"Вы действительно хотите удалить оборудование?\n\n" +
            $"ID: {id}\nНазвание: {name}",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool success = _equipmentService.Delete(id);
                if (success)
                {
                    LoadEquipmentData();
                    MessageBox.Show("Оборудование успешно удалено!", "Успех");
                }
                else
                {
                    MessageBox.Show("Не удалось удалить оборудование.", "Ошибка");
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите оборудование для редактирования!", "Предупреждение");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (var editForm = new EquipmentEditForm(id))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEquipmentData(); // обновляем таблицу после редактирования
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEquipmentData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция поиска пока в разработке", "Информация");
        }
        // Поля
        private Button btnAdd, btnEdit, btnDelete, btnRefresh, btnSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Col_EquipmentID, Col_Name, Col_Type,
        Col_SerialNumber, Col_CostPerDay, Col_Status, Col_Description;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }
        private TextBox txtSearch;
    }
}