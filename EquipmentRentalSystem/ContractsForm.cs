using System;
using System.Drawing;
using System.Windows.Forms;
using EquipmentRentalSystem.Models;
using EquipmentRentalSystem.Services;

namespace EquipmentRentalSystem
{
    public partial class ContractsForm : Form
    {
        private readonly ContractService _contractService;

        public ContractsForm()
        {
            InitializeComponent();
            this.Text = "Договоры проката - Прокат оборудования";
            _contractService = new ContractService();
            SetupColumns();
        }

        private void SetupColumns()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Client", "Клиент");
            dataGridView1.Columns.Add("Equipment", "Оборудование");
            dataGridView1.Columns.Add("StartDate", "Дата начала");
            dataGridView1.Columns.Add("EndDate", "Дата окончания");
            dataGridView1.Columns.Add("Amount", "Сумма");
            dataGridView1.Columns.Add("Status", "Статус");

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            LoadContractsData();
        }

        private void LoadContractsData()
        {
            try
            {
                var contracts = _contractService.GetAll();
                dataGridView1.Rows.Clear();

                if (contracts.Count == 0)
                {
                    // Тестовая запись
                    dataGridView1.Rows.Add(1, "Иванов Иван Иванович", "Экскаватор Caterpillar 320",
                                          "2026-05-20", "2026-06-05", "127500 ₽", "Активен");
                }
                else
                {
                    foreach (var c in contracts)
                    {
                        dataGridView1.Rows.Add(
                            c.Id,
                            c.ClientFullName,
                            c.EquipmentName,
                            c.RentalDate,
                            c.ReturnDate,
                            c.TotalAmount.ToString("N2") + " ₽",
                            c.Status
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки договоров:\n" + ex.Message, "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== КНОПКИ ==================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new ContractAddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadContractsData();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция редактирования договоров пока в разработке", "Информация");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция удаления договоров пока в разработке", "Информация");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadContractsData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция поиска пока в разработке", "Информация");
        }
    }
}