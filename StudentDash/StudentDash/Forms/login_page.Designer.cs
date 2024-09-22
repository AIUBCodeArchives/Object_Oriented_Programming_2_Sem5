namespace StudentDash.Forms
{
    partial class login_page
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_page));
            exit_btn = new PictureBox();
            user_login_btn = new Guna.UI2.WinForms.Guna2Button();
            admin_login_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            SuspendLayout();
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.FromArgb(57, 131, 120);
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.Image = Properties.Resources.icons8_cross_40;
            exit_btn.Location = new Point(1218, 12);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(70, 67);
            exit_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            exit_btn.TabIndex = 1;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // user_login_btn
            // 
            user_login_btn.BackColor = Color.FromArgb(57, 131, 120);
            user_login_btn.BorderColor = Color.Beige;
            user_login_btn.BorderRadius = 34;
            user_login_btn.Cursor = Cursors.Hand;
            user_login_btn.CustomizableEdges = customizableEdges1;
            user_login_btn.DisabledState.BorderColor = Color.DarkGray;
            user_login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            user_login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            user_login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            user_login_btn.FillColor = Color.FromArgb(49, 196, 141);
            user_login_btn.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_login_btn.ForeColor = Color.FromArgb(235, 216, 200);
            user_login_btn.Location = new Point(467, 503);
            user_login_btn.Name = "user_login_btn";
            user_login_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            user_login_btn.Size = new Size(366, 72);
            user_login_btn.TabIndex = 2;
            user_login_btn.Text = "Login/Signup as a user";
            // 
            // admin_login_btn
            // 
            admin_login_btn.BackColor = Color.FromArgb(57, 131, 120);
            admin_login_btn.BorderColor = Color.Beige;
            admin_login_btn.BorderRadius = 34;
            admin_login_btn.Cursor = Cursors.Hand;
            admin_login_btn.CustomizableEdges = customizableEdges3;
            admin_login_btn.DisabledState.BorderColor = Color.DarkGray;
            admin_login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            admin_login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            admin_login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            admin_login_btn.FillColor = Color.FromArgb(49, 196, 141);
            admin_login_btn.Font = new Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_login_btn.ForeColor = Color.FromArgb(235, 216, 200);
            admin_login_btn.Location = new Point(467, 599);
            admin_login_btn.Name = "admin_login_btn";
            admin_login_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            admin_login_btn.Size = new Size(366, 72);
            admin_login_btn.TabIndex = 3;
            admin_login_btn.Text = "Login as an admin";
            admin_login_btn.Click += admin_login_btn_Click;
            // 
            // login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Student_dash_1_;
            ClientSize = new Size(1300, 800);
            Controls.Add(admin_login_btn);
            Controls.Add(user_login_btn);
            Controls.Add(exit_btn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login_page";
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox exit_btn;
        private Guna.UI2.WinForms.Guna2Button user_login_btn;
        private Guna.UI2.WinForms.Guna2Button admin_login_btn;
    }
}