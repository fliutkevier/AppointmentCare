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
            label1 = new Label();
            btnAssignateAppointment = new Button();
            btnChangeAppointment = new Button();
            btnCancelAppointment = new Button();
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
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(781, 382);
            dgvAppointments.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 62);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 2;
            label1.Text = "Todos los Turnos:";
            // 
            // btnAssignateAppointment
            // 
            btnAssignateAppointment.Location = new Point(43, 509);
            btnAssignateAppointment.Name = "btnAssignateAppointment";
            btnAssignateAppointment.Size = new Size(172, 38);
            btnAssignateAppointment.TabIndex = 3;
            btnAssignateAppointment.Text = "Asignar Turno a Paciente";
            btnAssignateAppointment.UseVisualStyleBackColor = true;
            btnAssignateAppointment.Click += btnAssignateAppointment_Click;
            // 
            // btnChangeAppointment
            // 
            btnChangeAppointment.Location = new Point(241, 509);
            btnChangeAppointment.Name = "btnChangeAppointment";
            btnChangeAppointment.Size = new Size(172, 38);
            btnChangeAppointment.TabIndex = 4;
            btnChangeAppointment.Text = "Cambiar Turno";
            btnChangeAppointment.UseVisualStyleBackColor = true;
            btnChangeAppointment.Click += btnChangeAppointment_Click;
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.Location = new Point(445, 509);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(172, 38);
            btnCancelAppointment.TabIndex = 5;
            btnCancelAppointment.Text = "Cancelar Turno";
            btnCancelAppointment.UseVisualStyleBackColor = true;
            btnCancelAppointment.Click += btnCancelAppointment_Click_1;
            // 
            // frmAppointmentsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 606);
            Controls.Add(btnCancelAppointment);
            Controls.Add(btnChangeAppointment);
            Controls.Add(btnAssignateAppointment);
            Controls.Add(label1);
            Controls.Add(dgvAppointments);
            Controls.Add(btnAddAvailable);
            Name = "frmAppointmentsMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turnos";
            Load += frmAppointmentsMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAvailable;
        private DataGridView dgvAppointments;
        private Label label1;
        private Button btnAssignateAppointment;
        private Button btnChangeAppointment;
        private Button btnCancelAppointment;
    }
}