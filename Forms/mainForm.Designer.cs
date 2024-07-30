namespace Forms
{
    partial class mainForm
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
            lblWelcome = new Label();
            btnAdmin = new Button();
            btnDoctor = new Button();
            button1 = new Button();
            btnAppointment = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(188, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(64, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(85, 119);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(167, 40);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrator";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.Location = new Point(85, 209);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(167, 40);
            btnDoctor.TabIndex = 2;
            btnDoctor.Text = "Doctor";
            btnDoctor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(309, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            btnAppointment.Location = new Point(309, 159);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(75, 23);
            btnAppointment.TabIndex = 4;
            btnAppointment.Text = "Turnos";
            btnAppointment.UseVisualStyleBackColor = true;
            btnAppointment.Click += btnAppointment_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 337);
            Controls.Add(btnAppointment);
            Controls.Add(button1);
            Controls.Add(btnDoctor);
            Controls.Add(btnAdmin);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(474, 376);
            MinimumSize = new Size(474, 376);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment Care";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAdmin;
        private Button btnDoctor;
        private Button button1;
        private Button btnAppointment;
    }
}
