namespace UI
{
    partial class frmAddAvailableAppointment
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
            lblLegajo = new Label();
            dtpAppointment = new DateTimePicker();
            lblDate = new Label();
            lblTime = new Label();
            cbxDoctors = new ComboBox();
            cbxTime = new ComboBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(237, 396);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(44, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(40, 103);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 2;
            lblLegajo.Text = "Legajo";
            // 
            // dtpAppointment
            // 
            dtpAppointment.Location = new Point(111, 186);
            dtpAppointment.MaxDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpAppointment.MinDate = new DateTime(2024, 7, 28, 0, 0, 0, 0);
            dtpAppointment.Name = "dtpAppointment";
            dtpAppointment.Size = new Size(234, 23);
            dtpAppointment.TabIndex = 3;
            dtpAppointment.Value = new DateTime(2024, 7, 30, 18, 37, 35, 0);
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(44, 192);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Fecha";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(49, 264);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(33, 15);
            lblTime.TabIndex = 5;
            lblTime.Text = "Hora";
            // 
            // cbxDoctors
            // 
            cbxDoctors.FormattingEnabled = true;
            cbxDoctors.Location = new Point(111, 100);
            cbxDoctors.Name = "cbxDoctors";
            cbxDoctors.Size = new Size(201, 23);
            cbxDoctors.TabIndex = 6;
            // 
            // cbxTime
            // 
            cbxTime.FormattingEnabled = true;
            cbxTime.Location = new Point(111, 261);
            cbxTime.Name = "cbxTime";
            cbxTime.Size = new Size(76, 23);
            cbxTime.TabIndex = 7;
            // 
            // frmAddAvailableAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 450);
            Controls.Add(cbxTime);
            Controls.Add(cbxDoctors);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(dtpAppointment);
            Controls.Add(lblLegajo);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            MaximizeBox = false;
            MaximumSize = new Size(373, 489);
            MinimizeBox = false;
            MinimumSize = new Size(373, 489);
            Name = "frmAddAvailableAppointment";
            Text = "Agregando Turno Disponible";
            Load += frmAddAvailableAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private Label lblLegajo;
        private DateTimePicker dtpAppointment;
        private Label lblDate;
        private Label lblTime;
        private ComboBox cbxDoctors;
        private ComboBox cbxTime;
    }
}