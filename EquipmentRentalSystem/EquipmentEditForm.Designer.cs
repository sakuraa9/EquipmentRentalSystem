namespace EquipmentRentalSystem
{
    partial class EquipmentEditForm
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
            lblId = new Label();
            lblName = new Label();
            lblInventory = new Label();
            lblSerial = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtInventory = new TextBox();
            txtSerial = new TextBox();
            txtDescription = new TextBox();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblDescription = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(30, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Название:";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(30, 110);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(74, 15);
            lblInventory.TabIndex = 2;
            lblInventory.Text = "Инв. номер:";
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.Location = new Point(30, 150);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(104, 15);
            lblSerial.TabIndex = 3;
            lblSerial.Text = "Серийный номер";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 190);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(99, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Цена за сутки (₽)";
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
            // txtId
            // 
            txtId.Location = new Point(180, 30);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(180, 110);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(100, 23);
            txtInventory.TabIndex = 8;
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(180, 150);
            txtSerial.Name = "txtSerial";
            txtSerial.Size = new Size(100, 23);
            txtSerial.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(180, 270);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 11;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(180, 230);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(180, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 13;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(300, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 35);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 270);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(65, 15);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Описание:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 190);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 16;
            // 
            // EquipmentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(lblDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtSerial);
            Controls.Add(txtInventory);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblSerial);
            Controls.Add(lblInventory);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Location = new Point(500, 420);
            Name = "EquipmentEditForm";
            Text = "Цена за сутки (₽)";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblInventory;
        private Label lblSerial;
        private Label lblPrice;
        private Label lblStatus;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtInventory;
        private TextBox txtSerial;
        private TextBox txtDescription;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
        private Label lblDescription;
        private TextBox txtPrice;
    }
}