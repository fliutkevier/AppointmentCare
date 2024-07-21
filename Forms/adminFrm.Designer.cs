namespace UI
{
    partial class adminFrm
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
            btnAddPatient = new Button();
            dgvPatients = new DataGridView();
            dgvDoctors = new DataGridView();
            btnDeletePatient = new Button();
            btnModifyPatient = new Button();
            btnAddDoctor = new Button();
            btnModifyDoctor = new Button();
            btnDeleteDoctor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(12, 74);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(160, 33);
            btnAddPatient.TabIndex = 0;
            btnAddPatient.Text = "AGREGAR";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(210, 41);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.Size = new Size(917, 240);
            dgvPatients.TabIndex = 1;
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(210, 362);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(917, 242);
            dgvDoctors.TabIndex = 2;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Location = new Point(12, 225);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(160, 33);
            btnDeletePatient.TabIndex = 3;
            btnDeletePatient.Text = "ELIMINAR";
            btnDeletePatient.UseVisualStyleBackColor = true;
            // 
            // btnModifyPatient
            // 
            btnModifyPatient.Location = new Point(12, 149);
            btnModifyPatient.Name = "btnModifyPatient";
            btnModifyPatient.Size = new Size(160, 33);
            btnModifyPatient.TabIndex = 4;
            btnModifyPatient.Text = "MODIFICAR";
            btnModifyPatient.UseVisualStyleBackColor = true;
            btnModifyPatient.Click += btnModifyPatient_Click;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Location = new Point(12, 391);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(160, 33);
            btnAddDoctor.TabIndex = 5;
            btnAddDoctor.Text = "AGREGAR";
            btnAddDoctor.UseVisualStyleBackColor = true;
            // 
            // btnModifyDoctor
            // 
            btnModifyDoctor.Location = new Point(12, 467);
            btnModifyDoctor.Name = "btnModifyDoctor";
            btnModifyDoctor.Size = new Size(160, 33);
            btnModifyDoctor.TabIndex = 6;
            btnModifyDoctor.Text = "MODIFICAR";
            btnModifyDoctor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDoctor
            // 
            btnDeleteDoctor.Location = new Point(12, 534);
            btnDeleteDoctor.Name = "btnDeleteDoctor";
            btnDeleteDoctor.Size = new Size(160, 33);
            btnDeleteDoctor.TabIndex = 7;
            btnDeleteDoctor.Text = "ELIMINAR";
            btnDeleteDoctor.UseVisualStyleBackColor = true;
            // 
            // adminFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 642);
            Controls.Add(btnDeleteDoctor);
            Controls.Add(btnModifyDoctor);
            Controls.Add(btnAddDoctor);
            Controls.Add(btnModifyPatient);
            Controls.Add(btnDeletePatient);
            Controls.Add(dgvDoctors);
            Controls.Add(dgvPatients);
            Controls.Add(btnAddPatient);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "adminFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Profile";
            Load += adminFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPatient;
        private DataGridView dgvPatients;
        private DataGridView dgvDoctors;
        private Button btnDeletePatient;
        private Button btnModifyPatient;
        private Button btnAddDoctor;
        private Button btnModifyDoctor;
        private Button btnDeleteDoctor;
    }
}