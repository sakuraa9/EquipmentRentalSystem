using System;
using System.Windows.Forms;

namespace EquipmentRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Прокат оборудования - Главное меню";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Пользователь: admin (Администратор)";
        }

        // ================== МЕНЮ ==================
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Оборудование())
            {
                form.ShowDialog();
            }
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ClientsForm())
            {
                form.ShowDialog();
            }
        }

        private void договорыПрокатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ContractsForm())
            {
                form.ShowDialog();
            }
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new UsersForm())
            {
                form.ShowDialog();
            }
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ReportsForm())
            {
                form.ShowDialog();
            }
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}