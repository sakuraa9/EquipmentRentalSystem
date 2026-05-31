namespace EquipmentRentalSystem
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnEquipmentStatus = new Button();
            btnActiveContracts = new Button();
            btnRevenueReport = new Button();
            btnEquipmentInRepair = new Button();
            btnClose = new Button();
            txtReport = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "Выберите отчёт:";
            // 
            // btnEquipmentStatus
            // 
            btnEquipmentStatus.Location = new Point(50, 80);
            btnEquipmentStatus.Name = "btnEquipmentStatus";
            btnEquipmentStatus.Size = new Size(280, 50);
            btnEquipmentStatus.TabIndex = 1;
            btnEquipmentStatus.Text = "Оборудование по статусам";
            btnEquipmentStatus.UseVisualStyleBackColor = true;
            btnEquipmentStatus.Click += btnEquipmentStatus_Click;
            // 
            // btnActiveContracts
            // 
            btnActiveContracts.Location = new Point(50, 140);
            btnActiveContracts.Name = "btnActiveContracts";
            btnActiveContracts.Size = new Size(280, 50);
            btnActiveContracts.TabIndex = 2;
            btnActiveContracts.Text = "Активные договоры";
            btnActiveContracts.UseVisualStyleBackColor = true;
            btnActiveContracts.Click += btnActiveContracts_Click;
            // 
            // btnRevenueReport
            // 
            btnRevenueReport.Location = new Point(50, 200);
            btnRevenueReport.Name = "btnRevenueReport";
            btnRevenueReport.Size = new Size(280, 50);
            btnRevenueReport.TabIndex = 3;
            btnRevenueReport.Text = "Доход за период";
            btnRevenueReport.UseVisualStyleBackColor = true;
            btnRevenueReport.Click += btnRevenueReport_Click;
            // 
            // btnEquipmentInRepair
            // 
            btnEquipmentInRepair.Location = new Point(50, 260);
            btnEquipmentInRepair.Name = "btnEquipmentInRepair";
            btnEquipmentInRepair.Size = new Size(280, 50);
            btnEquipmentInRepair.TabIndex = 4;
            btnEquipmentInRepair.Text = "Оборудование в ремонте";
            btnEquipmentInRepair.UseVisualStyleBackColor = true;
            btnEquipmentInRepair.Click += btnEquipmentInRepair_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(296, 428);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtReport
            // 
            txtReport.Font = new Font("Segoe UI", 10F);
            txtReport.Location = new Point(380, 80);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.ScrollBars = ScrollBars.Vertical;
            txtReport.Size = new Size(290, 350);
            txtReport.TabIndex = 6;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(txtReport);
            Controls.Add(btnClose);
            Controls.Add(btnEquipmentInRepair);
            Controls.Add(btnRevenueReport);
            Controls.Add(btnActiveContracts);
            Controls.Add(btnEquipmentStatus);
            Controls.Add(label1);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Отчёты - Прокат оборудования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEquipmentStatus;
        private Button btnActiveContracts;
        private Button btnRevenueReport;
        private Button btnEquipmentInRepair;
        private Button btnClose;
        private TextBox txtReport;
    }
}