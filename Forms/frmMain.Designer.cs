namespace Forms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPatientsDoctors = new Button();
            btnDoctors = new Button();
            btnAppointmentSection = new Button();
            SuspendLayout();
            // 
            // btnPatientsDoctors
            // 
            btnPatientsDoctors.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPatientsDoctors.Location = new Point(12, 12);
            btnPatientsDoctors.Name = "btnPatientsDoctors";
            btnPatientsDoctors.Size = new Size(142, 49);
            btnPatientsDoctors.TabIndex = 0;
            btnPatientsDoctors.Text = "Sección Pacientes y Profesionales";
            btnPatientsDoctors.UseVisualStyleBackColor = true;
            btnPatientsDoctors.Click += btnPatientsDoctors_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDoctors.Location = new Point(202, 12);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(142, 49);
            btnDoctors.TabIndex = 1;
            btnDoctors.Text = "Sección de Doctor";
            btnDoctors.UseVisualStyleBackColor = true;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnAppointmentSection
            // 
            btnAppointmentSection.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppointmentSection.Location = new Point(102, 84);
            btnAppointmentSection.Name = "btnAppointmentSection";
            btnAppointmentSection.Size = new Size(142, 49);
            btnAppointmentSection.TabIndex = 2;
            btnAppointmentSection.Text = "Sección Turnos";
            btnAppointmentSection.UseVisualStyleBackColor = true;
            btnAppointmentSection.Click += btnAppointmentSection_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 146);
            Controls.Add(btnAppointmentSection);
            Controls.Add(btnDoctors);
            Controls.Add(btnPatientsDoctors);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(474, 376);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment Care";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPatientsDoctors;
        private Button btnDoctors;
        private Button btnAppointmentSection;
    }
}
