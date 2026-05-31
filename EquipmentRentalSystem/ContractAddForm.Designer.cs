namespace EquipmentRentalSystem
{
    partial class ContractAddForm
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
            lblClient = new Label();
            lblEquipment = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblAmount = new Label();
            lblStatus = new Label();
            cmbClient = new ComboBox();
            cmbEquipment = new ComboBox();
            cmbStatus = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtAmount = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(30, 30);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(49, 15);
            lblClient.TabIndex = 0;
            lblClient.Text = "Клиент:";
            // 
            // lblEquipment
            // 
            lblEquipment.AutoSize = true;
            lblEquipment.Location = new Point(30, 70);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(91, 15);
            lblEquipment.TabIndex = 1;
            lblEquipment.Text = "Оборудование:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(30, 110);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(77, 15);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Дата начала:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(30, 150);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(98, 15);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "Дата окончания:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(30, 190);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(65, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Сумма (₽):";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 230);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Статус:";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(160, 30);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(121, 23);
            cmbClient.TabIndex = 6;
            // 
            // cmbEquipment
            // 
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(160, 70);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(121, 23);
            cmbEquipment.TabIndex = 7;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(160, 230);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(160, 110);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(160, 150);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 10;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(160, 190);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(160, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(280, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ContractAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 341);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtAmount);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cmbStatus);
            Controls.Add(cmbEquipment);
            Controls.Add(cmbClient);
            Controls.Add(lblStatus);
            Controls.Add(lblAmount);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblEquipment);
            Controls.Add(lblClient);
            Name = "ContractAddForm";
            Text = "ContractAddForm";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClient;
        private Label lblEquipment;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblAmount;
        private Label lblStatus;
        private ComboBox cmbClient;
        private ComboBox cmbEquipment;
        private ComboBox cmbStatus;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtAmount;
        private Button btnSave;
        private Button btnCancel;
    }
}