using System;
using System.Windows.Forms;
using EquipmentRentalSystem.Services;

namespace EquipmentRentalSystem
{
    public partial class ReportsForm : Form
    {
        private readonly EquipmentService _equipmentService;
        private readonly ContractService _contractService;

        public ReportsForm()
        {
            InitializeComponent();
            this.Text = "Отчёты - Прокат оборудования";
            _equipmentService = new EquipmentService();
            _contractService = new ContractService();
        }

        private void btnEquipmentStatus_Click(object sender, EventArgs e)
        {
            txtReport.Clear();
            txtReport.AppendText("=== ОТЧЁТ: Оборудование по статусам ===\n\n");

            // Здесь можно позже сделать настоящий подсчёт из базы
            txtReport.AppendText("Available: 12 шт.\n");
            txtReport.AppendText("In Repair: 3 шт.\n");
            txtReport.AppendText("Rented: 5 шт.\n");
            txtReport.AppendText("Total: 20 шт.\n");
        }

        private void btnActiveContracts_Click(object sender, EventArgs e)
        {
            txtReport.Clear();
            txtReport.AppendText("=== ОТЧЁТ: Активные договоры ===\n\n");
            txtReport.AppendText("Всего активных договоров: 8\n\n");
            txtReport.AppendText("1. Иванов И.И. - Экскаватор (до 15.06.2026)\n");
            txtReport.AppendText("2. Сидорова А.П. - Автокран (до 10.06.2026)\n");
            txtReport.AppendText("3. Петров С.В. - Бульдозер (до 05.07.2026)\n");
        }

        private void btnRevenueReport_Click(object sender, EventArgs e)
        {
            txtReport.Clear();
            txtReport.AppendText("=== ОТЧЁТ: Доход за период ===\n\n");
            txtReport.AppendText("За май 2026: 1 245 000 ₽\n");
            txtReport.AppendText("За текущий период: 987 500 ₽\n\n");
            txtReport.AppendText("Самое доходное оборудование: Автокран Liebherr\n");
        }

        private void btnEquipmentInRepair_Click(object sender, EventArgs e)
        {
            txtReport.Clear();
            txtReport.AppendText("=== ОТЧЁТ: Оборудование в ремонте ===\n\n");
            txtReport.AppendText("1. Бульдозер Komatsu D65 - Гусеницы\n");
            txtReport.AppendText("2. Генератор Honda 10kW - Двигатель\n");
            txtReport.AppendText("3. Экскаватор Caterpillar - Гидравлика\n");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
