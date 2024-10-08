﻿namespace UI
{
    partial class frmAdmin
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
            lblPatients = new Label();
            lblDoctors = new Label();
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
            dgvPatients.ReadOnly = true;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(917, 240);
            dgvPatients.TabIndex = 1;
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(210, 362);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            btnDeletePatient.Click += btnDeletePatient_Click;
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
            btnAddDoctor.Click += btnAddDoctor_Click;
            // 
            // btnModifyDoctor
            // 
            btnModifyDoctor.Location = new Point(12, 467);
            btnModifyDoctor.Name = "btnModifyDoctor";
            btnModifyDoctor.Size = new Size(160, 33);
            btnModifyDoctor.TabIndex = 6;
            btnModifyDoctor.Text = "MODIFICAR";
            btnModifyDoctor.UseVisualStyleBackColor = true;
            btnModifyDoctor.Click += btnModifyDoctor_Click;
            // 
            // btnDeleteDoctor
            // 
            btnDeleteDoctor.Location = new Point(12, 534);
            btnDeleteDoctor.Name = "btnDeleteDoctor";
            btnDeleteDoctor.Size = new Size(160, 33);
            btnDeleteDoctor.TabIndex = 7;
            btnDeleteDoctor.Text = "ELIMINAR";
            btnDeleteDoctor.UseVisualStyleBackColor = true;
            btnDeleteDoctor.Click += btnDeleteDoctor_Click;
            // 
            // lblPatients
            // 
            lblPatients.AutoSize = true;
            lblPatients.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatients.Location = new Point(210, 6);
            lblPatients.Name = "lblPatients";
            lblPatients.Size = new Size(122, 32);
            lblPatients.TabIndex = 8;
            lblPatients.Text = "Pacientes:";
            // 
            // lblDoctors
            // 
            lblDoctors.AutoSize = true;
            lblDoctors.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctors.Location = new Point(210, 327);
            lblDoctors.Name = "lblDoctors";
            lblDoctors.Size = new Size(117, 32);
            lblDoctors.TabIndex = 9;
            lblDoctors.Text = "Doctores:";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 642);
            Controls.Add(lblDoctors);
            Controls.Add(lblPatients);
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
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Profile";
            Load += adminFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblPatients;
        private Label lblDoctors;
    }
}