namespace UI
{
    partial class frmAppointmentsMain
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
            btnAddAvailable = new Button();
            dgvAppointments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // btnAddAvailable
            // 
            btnAddAvailable.Location = new Point(262, 37);
            btnAddAvailable.Name = "btnAddAvailable";
            btnAddAvailable.Size = new Size(284, 23);
            btnAddAvailable.TabIndex = 0;
            btnAddAvailable.Text = "Agregar turno disponible";
            btnAddAvailable.UseVisualStyleBackColor = true;
            btnAddAvailable.Click += btnAddAvailable_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(39, 93);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(781, 382);
            dgvAppointments.TabIndex = 1;
            // 
            // frmAppointmentsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 606);
            Controls.Add(dgvAppointments);
            Controls.Add(btnAddAvailable);
            Name = "frmAppointmentsMain";
            Text = "frmAppointmentsMain";
            Load += frmAppointmentsMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddAvailable;
        private DataGridView dgvAppointments;
    }
}