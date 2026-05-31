namespace EquipmentRentalSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new ToolStripMenuItem();
            оборудованиеToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            договорыПрокатаToolStripMenuItem = new ToolStripMenuItem();
            администрированиеToolStripMenuItem = new ToolStripMenuItem();
            пользователиToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, dataGridView1, операцииToolStripMenuItem, администрированиеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(108, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.DropDownItems.AddRange(new ToolStripItem[] { оборудованиеToolStripMenuItem, клиентыToolStripMenuItem });
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(94, 20);
            dataGridView1.Text = "Справочники";
            // 
            // оборудованиеToolStripMenuItem
            // 
            оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            оборудованиеToolStripMenuItem.Size = new Size(180, 22);
            оборудованиеToolStripMenuItem.Text = "Оборудование";
            оборудованиеToolStripMenuItem.Click += оборудованиеToolStripMenuItem_Click;
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(180, 22);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { договорыПрокатаToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // договорыПрокатаToolStripMenuItem
            // 
            договорыПрокатаToolStripMenuItem.Name = "договорыПрокатаToolStripMenuItem";
            договорыПрокатаToolStripMenuItem.Size = new Size(177, 22);
            договорыПрокатаToolStripMenuItem.Text = "Договоры проката";
            договорыПрокатаToolStripMenuItem.Click += договорыПрокатаToolStripMenuItem_Click;
            // 
            // администрированиеToolStripMenuItem
            // 
            администрированиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пользователиToolStripMenuItem, отчетыToolStripMenuItem });
            администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            администрированиеToolStripMenuItem.Size = new Size(134, 20);
            администрированиеToolStripMenuItem.Text = "Администрирование";
            администрированиеToolStripMenuItem.Click += администрированиеToolStripMenuItem_Click;
            // 
            // пользователиToolStripMenuItem
            // 
            пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            пользователиToolStripMenuItem.Size = new Size(180, 22);
            пользователиToolStripMenuItem.Text = "Пользователи";
            пользователиToolStripMenuItem.Click += пользователиToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(180, 22);
            отчетыToolStripMenuItem.Text = "Отчёты";
            отчетыToolStripMenuItem.Click += отчетыToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(531, 24);
            label2.Name = "label2";
            label2.Size = new Size(253, 19);
            label2.TabIndex = 1;
            label2.Text = "Пользователь: admin (Администратор)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Прокат оборудования - Главное меню";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem dataGridView1;
        private ToolStripMenuItem оборудованиеToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem договорыПрокатаToolStripMenuItem;
        private ToolStripMenuItem администрированиеToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}