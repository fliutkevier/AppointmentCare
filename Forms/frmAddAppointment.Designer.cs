namespace UI
{
    partial class frmAddAppointment
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
            btnOk = new Button();
            btnCancel = new Button();
            lblDoctorInfo = new Label();
            lblTime = new Label();
            cbxDoctors = new ComboBox();
            cbxTime = new ComboBox();
            cbxSpeciality = new ComboBox();
            lblSpeciality = new Label();
            lblDoctorName = new Label();
            mcAppointmentDate = new MonthCalendar();
            btnFindDates = new Button();
            lblLicense = new Label();
            lblPatient = new Label();
            cbxPatient = new ComboBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(303, 555);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(36, 555);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDoctorInfo
            // 
            lblDoctorInfo.AutoSize = true;
            lblDoctorInfo.Location = new Point(16, 103);
            lblDoctorInfo.Name = "lblDoctorInfo";
            lblDoctorInfo.Size = new Size(66, 15);
            lblDoctorInfo.TabIndex = 2;
            lblDoctorInfo.Text = "Profesional";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(61, 407);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(33, 15);
            lblTime.TabIndex = 5;
            lblTime.Text = "Hora";
            // 
            // cbxDoctors
            // 
            cbxDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDoctors.FormattingEnabled = true;
            cbxDoctors.Location = new Point(111, 100);
            cbxDoctors.Name = "cbxDoctors";
            cbxDoctors.Size = new Size(248, 23);
            cbxDoctors.TabIndex = 6;
            cbxDoctors.SelectedIndexChanged += cbxDoctors_SelectedIndexChanged;
            // 
            // cbxTime
            // 
            cbxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTime.FormattingEnabled = true;
            cbxTime.Location = new Point(111, 404);
            cbxTime.Name = "cbxTime";
            cbxTime.Size = new Size(76, 23);
            cbxTime.TabIndex = 7;
            // 
            // cbxSpeciality
            // 
            cbxSpeciality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSpeciality.FormattingEnabled = true;
            cbxSpeciality.Location = new Point(111, 49);
            cbxSpeciality.Name = "cbxSpeciality";
            cbxSpeciality.Size = new Size(248, 23);
            cbxSpeciality.TabIndex = 8;
            cbxSpeciality.SelectedIndexChanged += cbxSpeciality_SelectedIndexChanged;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Location = new Point(10, 52);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(72, 15);
            lblSpeciality.TabIndex = 9;
            lblSpeciality.Text = "Especialidad";
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Location = new Point(164, 205);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(0, 15);
            lblDoctorName.TabIndex = 10;
            // 
            // mcAppointmentDate
            // 
            mcAppointmentDate.Location = new Point(111, 217);
            mcAppointmentDate.Name = "mcAppointmentDate";
            mcAppointmentDate.TabIndex = 11;
            mcAppointmentDate.DateChanged += mcAppointmentDate_DateChanged;
            // 
            // btnFindDates
            // 
            btnFindDates.Location = new Point(176, 173);
            btnFindDates.Name = "btnFindDates";
            btnFindDates.Size = new Size(128, 23);
            btnFindDates.TabIndex = 12;
            btnFindDates.Text = "Buscar Fechas";
            btnFindDates.UseVisualStyleBackColor = true;
            btnFindDates.Click += btnFindDates_Click;
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(111, 142);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(0, 15);
            lblLicense.TabIndex = 13;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(30, 463);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(52, 15);
            lblPatient.TabIndex = 14;
            lblPatient.Text = "Paciente";
            // 
            // cbxPatient
            // 
            cbxPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPatient.FormattingEnabled = true;
            cbxPatient.Location = new Point(111, 460);
            cbxPatient.Name = "cbxPatient";
            cbxPatient.Size = new Size(248, 23);
            cbxPatient.TabIndex = 15;
            // 
            // frmAddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 590);
            Controls.Add(cbxPatient);
            Controls.Add(lblPatient);
            Controls.Add(lblLicense);
            Controls.Add(btnFindDates);
            Controls.Add(mcAppointmentDate);
            Controls.Add(lblDoctorName);
            Controls.Add(lblSpeciality);
            Controls.Add(cbxSpeciality);
            Controls.Add(cbxTime);
            Controls.Add(cbxDoctors);
            Controls.Add(lblTime);
            Controls.Add(lblDoctorInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddAppointment";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregando Turno Disponible";
            Load += frmAddAvailableAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Label lblDoctorInfo;
        private DateTimePicker dtpAppointment;
        private Label lblTime;
        private ComboBox cbxDoctors;
        private ComboBox cbxTime;
        private ComboBox cbxSpeciality;
        private Label lblSpeciality;
        private Label lblDoctorName;
        private MonthCalendar mcAppointmentDate;
        private Button btnFindDates;
        private Label lblLicense;
        private Label lblPatient;
        private ComboBox cbxPatient;
    }
}