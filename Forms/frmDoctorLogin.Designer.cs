namespace UI
{
    partial class frmDoctorLogin
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
            lblLicenseLogin = new Label();
            btnLogin = new Button();
            tbxLicense = new TextBox();
            SuspendLayout();
            // 
            // lblLicenseLogin
            // 
            lblLicenseLogin.AutoSize = true;
            lblLicenseLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseLogin.Location = new Point(125, 18);
            lblLicenseLogin.Name = "lblLicenseLogin";
            lblLicenseLogin.Size = new Size(156, 25);
            lblLicenseLogin.TabIndex = 0;
            lblLicenseLogin.Text = "Ingrese su legajo";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(167, 97);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(78, 32);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxLicense
            // 
            tbxLicense.Location = new Point(90, 57);
            tbxLicense.Name = "tbxLicense";
            tbxLicense.Size = new Size(226, 23);
            tbxLicense.TabIndex = 2;
            // 
            // frmDoctorLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 167);
            Controls.Add(tbxLicense);
            Controls.Add(btnLogin);
            Controls.Add(lblLicenseLogin);
            MaximizeBox = false;
            Name = "frmDoctorLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingrese a la sección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLicenseLogin;
        private Button btnLogin;
        private TextBox tbxLicense;
    }
}