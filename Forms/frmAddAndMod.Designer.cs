namespace UI
{
    partial class frmAddAndMod
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
            lblTitle = new Label();
            lblName = new Label();
            lblLastname = new Label();
            lblDni = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            tbxName = new TextBox();
            tbxLastname = new TextBox();
            tbxDni = new TextBox();
            tbxAddress = new TextBox();
            tbxPhone = new TextBox();
            lblHealthInsurance = new Label();
            lblHealthInsuranceNumber = new Label();
            cbxHealthInsurance = new ComboBox();
            tbxHealthInsuranceNumber = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(155, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(69, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Agregando ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(45, 125);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(51, 15);
            lblLastname.TabIndex = 2;
            lblLastname.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(69, 161);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(39, 195);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Dirección";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(44, 234);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(52, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Teléfono";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(155, 269);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(119, 15);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Fecha de Nacimiento";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(92, 297);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(244, 23);
            dtpBirthday.TabIndex = 7;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(108, 90);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(204, 23);
            tbxName.TabIndex = 8;
            // 
            // tbxLastname
            // 
            tbxLastname.Location = new Point(108, 122);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new Size(204, 23);
            tbxLastname.TabIndex = 9;
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(108, 158);
            tbxDni.MaxLength = 8;
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(204, 23);
            tbxDni.TabIndex = 10;
            // 
            // tbxAddress
            // 
            tbxAddress.Location = new Point(108, 192);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(204, 23);
            tbxAddress.TabIndex = 11;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(108, 231);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(204, 23);
            tbxPhone.TabIndex = 12;
            // 
            // lblHealthInsurance
            // 
            lblHealthInsurance.AutoSize = true;
            lblHealthInsurance.Location = new Point(29, 350);
            lblHealthInsurance.Name = "lblHealthInsurance";
            lblHealthInsurance.Size = new Size(67, 15);
            lblHealthInsurance.TabIndex = 13;
            lblHealthInsurance.Text = "Obra Social";
            // 
            // lblHealthInsuranceNumber
            // 
            lblHealthInsuranceNumber.AutoSize = true;
            lblHealthInsuranceNumber.Location = new Point(45, 388);
            lblHealthInsuranceNumber.Name = "lblHealthInsuranceNumber";
            lblHealthInsuranceNumber.Size = new Size(51, 15);
            lblHealthInsuranceNumber.TabIndex = 14;
            lblHealthInsuranceNumber.Text = "Numero";
            // 
            // cbxHealthInsurance
            // 
            cbxHealthInsurance.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHealthInsurance.FormattingEnabled = true;
            cbxHealthInsurance.Location = new Point(108, 347);
            cbxHealthInsurance.Name = "cbxHealthInsurance";
            cbxHealthInsurance.Size = new Size(204, 23);
            cbxHealthInsurance.TabIndex = 15;
            // 
            // tbxHealthInsuranceNumber
            // 
            tbxHealthInsuranceNumber.Location = new Point(108, 385);
            tbxHealthInsuranceNumber.Name = "tbxHealthInsuranceNumber";
            tbxHealthInsuranceNumber.Size = new Size(204, 23);
            tbxHealthInsuranceNumber.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(261, 466);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Aceptar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(57, 466);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddAndMod
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(379, 537);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(tbxHealthInsuranceNumber);
            Controls.Add(cbxHealthInsurance);
            Controls.Add(lblHealthInsuranceNumber);
            Controls.Add(lblHealthInsurance);
            Controls.Add(tbxPhone);
            Controls.Add(tbxAddress);
            Controls.Add(tbxDni);
            Controls.Add(tbxLastname);
            Controls.Add(tbxName);
            Controls.Add(dtpBirthday);
            Controls.Add(lblBirthday);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblDni);
            Controls.Add(lblLastname);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            MaximizeBox = false;
            MaximumSize = new Size(395, 576);
            MinimizeBox = false;
            MinimumSize = new Size(395, 576);
            Name = "frmAddAndMod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGANDO...";
            Load += frmAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblLastname;
        private Label lblDni;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private TextBox tbxName;
        private TextBox tbxLastname;
        private TextBox tbxDni;
        private TextBox tbxAddress;
        private TextBox tbxPhone;
        private Label lblHealthInsurance;
        private Label lblHealthInsuranceNumber;
        private ComboBox cbxHealthInsurance;
        private TextBox tbxHealthInsuranceNumber;
        private Button btnAdd;
        private Button btnCancel;
    }
}