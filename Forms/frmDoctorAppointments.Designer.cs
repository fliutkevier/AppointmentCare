namespace UI
{
    partial class frmDoctorAppointments
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
            dgvAppointments = new DataGridView();
            btnPatientAttended = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(12, 12);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(776, 389);
            dgvAppointments.TabIndex = 0;
            // 
            // btnPatientAttended
            // 
            btnPatientAttended.Location = new Point(12, 415);
            btnPatientAttended.Name = "btnPatientAttended";
            btnPatientAttended.Size = new Size(144, 23);
            btnPatientAttended.TabIndex = 1;
            btnPatientAttended.Text = "Atendido";
            btnPatientAttended.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmDoctorAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnPatientAttended);
            Controls.Add(dgvAppointments);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDoctorAppointments";
            Text = "Turnos de ";
            Load += frmDoctorAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAppointments;
        private Button btnPatientAttended;
        private Button btnClose;
    }
}