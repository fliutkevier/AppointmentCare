namespace UI
{
    partial class frmDoctorAddAndMod
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
            btnCancel = new Button();
            btnAccept = new Button();
            tbxPhone = new TextBox();
            tbxAddress = new TextBox();
            tbxDni = new TextBox();
            tbxLastname = new TextBox();
            tbxName = new TextBox();
            dtpBirthday = new DateTimePicker();
            lblBirthday = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblDni = new Label();
            lblLastname = new Label();
            lblName = new Label();
            lblSpeciality = new Label();
            lblLicense = new Label();
            cbxSpeciality = new ComboBox();
            tbxLicense = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(59, 445);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(263, 445);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 31;
            btnAccept.Text = "Aceptar";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(110, 210);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(204, 23);
            tbxPhone.TabIndex = 30;
            // 
            // tbxAddress
            // 
            tbxAddress.Location = new Point(110, 171);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(204, 23);
            tbxAddress.TabIndex = 29;
            // 
            // tbxDni
            // 
            tbxDni.Location = new Point(110, 137);
            tbxDni.MaxLength = 8;
            tbxDni.Name = "tbxDni";
            tbxDni.Size = new Size(204, 23);
            tbxDni.TabIndex = 28;
            // 
            // tbxLastname
            // 
            tbxLastname.Location = new Point(110, 101);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new Size(204, 23);
            tbxLastname.TabIndex = 27;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(110, 69);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(204, 23);
            tbxName.TabIndex = 26;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(94, 276);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(244, 23);
            dtpBirthday.TabIndex = 25;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(157, 248);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(119, 15);
            lblBirthday.TabIndex = 24;
            lblBirthday.Text = "Fecha de Nacimiento";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(46, 213);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(52, 15);
            lblPhone.TabIndex = 23;
            lblPhone.Text = "Teléfono";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(41, 174);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 22;
            lblAddress.Text = "Dirección";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(71, 140);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 21;
            lblDni.Text = "DNI";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(47, 104);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(51, 15);
            lblLastname.TabIndex = 20;
            lblLastname.Text = "Apellido";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 19;
            lblName.Text = "Nombre";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Location = new Point(26, 330);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(72, 15);
            lblSpeciality.TabIndex = 33;
            lblSpeciality.Text = "Especialidad";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(48, 371);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(50, 15);
            lblLicense.TabIndex = 34;
            lblLicense.Text = "Licencia";
            // 
            // cbxSpeciality
            // 
            cbxSpeciality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSpeciality.FormattingEnabled = true;
            cbxSpeciality.Location = new Point(110, 327);
            cbxSpeciality.Name = "cbxSpeciality";
            cbxSpeciality.Size = new Size(204, 23);
            cbxSpeciality.TabIndex = 35;
            // 
            // tbxLicense
            // 
            tbxLicense.Location = new Point(110, 368);
            tbxLicense.Name = "tbxLicense";
            tbxLicense.Size = new Size(204, 23);
            tbxLicense.TabIndex = 36;
            // 
            // frmDoctorAddAndMod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 537);
            Controls.Add(tbxLicense);
            Controls.Add(cbxSpeciality);
            Controls.Add(lblLicense);
            Controls.Add(lblSpeciality);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
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
            MaximizeBox = false;
            MaximumSize = new Size(395, 576);
            MinimizeBox = false;
            MinimumSize = new Size(395, 576);
            Name = "frmDoctorAddAndMod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregando";
            Load += frmDoctorAddAndMod_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAccept;
        private TextBox tbxPhone;
        private TextBox tbxAddress;
        private TextBox tbxDni;
        private TextBox tbxLastname;
        private TextBox tbxName;
        private DateTimePicker dtpBirthday;
        private Label lblBirthday;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblDni;
        private Label lblLastname;
        private Label lblName;
        private Label lblSpeciality;
        private Label lblLicense;
        private ComboBox cbxSpeciality;
        private TextBox tbxLicense;
    }
}