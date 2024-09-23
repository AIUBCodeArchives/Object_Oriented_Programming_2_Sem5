namespace StudentDash.Forms
{
    partial class admin_login_page
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login_page));
            exit_btn = new PictureBox();
            pictureBox1 = new PictureBox();
            admin_login_lbl = new Label();
            username_lbl = new Label();
            username_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            password_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            password_lbl = new Label();
            security_key_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            security_key_lbl = new Label();
            admin_login_btn = new Guna.UI2.WinForms.Guna2Button();
            forgot_password_btn = new Label();
            back_btn = new PictureBox();
            cant_login_lbl = new Label();
            forgot_password_lbl = new LinkLabel();
            contact_customs_btn = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)back_btn).BeginInit();
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
            exit_btn.TabIndex = 2;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(57, 131, 120);
            pictureBox1.Image = Properties.Resources.icons8_admin_50;
            pictureBox1.Location = new Point(588, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // admin_login_lbl
            // 
            admin_login_lbl.AutoSize = true;
            admin_login_lbl.BackColor = Color.Transparent;
            admin_login_lbl.Font = new Font("Microsoft Sans Serif", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_login_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            admin_login_lbl.Location = new Point(485, 164);
            admin_login_lbl.Name = "admin_login_lbl";
            admin_login_lbl.Size = new Size(339, 63);
            admin_login_lbl.TabIndex = 4;
            admin_login_lbl.Text = "Admin Login";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            username_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            username_lbl.Location = new Point(365, 253);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(363, 39);
            username_lbl.TabIndex = 5;
            username_lbl.Text = "Username/StudentID:";
            // 
            // username_txtbox
            // 
            username_txtbox.BackColor = Color.Transparent;
            username_txtbox.BorderColor = Color.FromArgb(201, 239, 199);
            username_txtbox.BorderRadius = 27;
            username_txtbox.CustomizableEdges = customizableEdges1;
            username_txtbox.DefaultText = "";
            username_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username_txtbox.FillColor = Color.FromArgb(201, 239, 199);
            username_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txtbox.Font = new Font("Segoe UI", 9F);
            username_txtbox.ForeColor = Color.Black;
            username_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txtbox.Location = new Point(353, 296);
            username_txtbox.Margin = new Padding(3, 4, 3, 4);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.PasswordChar = '\0';
            username_txtbox.PlaceholderForeColor = Color.Gray;
            username_txtbox.PlaceholderText = "Enter your name";
            username_txtbox.SelectedText = "";
            username_txtbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            username_txtbox.Size = new Size(595, 60);
            username_txtbox.TabIndex = 6;
            // 
            // password_txtbox
            // 
            password_txtbox.BackColor = Color.Transparent;
            password_txtbox.BorderColor = Color.FromArgb(201, 239, 199);
            password_txtbox.BorderRadius = 27;
            password_txtbox.CustomizableEdges = customizableEdges3;
            password_txtbox.DefaultText = "";
            password_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password_txtbox.FillColor = Color.FromArgb(201, 239, 199);
            password_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password_txtbox.Font = new Font("Segoe UI", 9F);
            password_txtbox.ForeColor = Color.Black;
            password_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password_txtbox.Location = new Point(353, 406);
            password_txtbox.Margin = new Padding(3, 4, 3, 4);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.PlaceholderForeColor = Color.Gray;
            password_txtbox.PlaceholderText = "Enter your password";
            password_txtbox.SelectedText = "";
            password_txtbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password_txtbox.Size = new Size(595, 60);
            password_txtbox.TabIndex = 8;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.BackColor = Color.Transparent;
            password_lbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            password_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            password_lbl.Location = new Point(365, 363);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(185, 39);
            password_lbl.TabIndex = 7;
            password_lbl.Text = "Password:";
            // 
            // security_key_txtbox
            // 
            security_key_txtbox.BackColor = Color.Transparent;
            security_key_txtbox.BorderColor = Color.FromArgb(201, 239, 199);
            security_key_txtbox.BorderRadius = 27;
            security_key_txtbox.CustomizableEdges = customizableEdges5;
            security_key_txtbox.DefaultText = "";
            security_key_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            security_key_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            security_key_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            security_key_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            security_key_txtbox.FillColor = Color.FromArgb(201, 239, 199);
            security_key_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            security_key_txtbox.Font = new Font("Segoe UI", 9F);
            security_key_txtbox.ForeColor = Color.Black;
            security_key_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            security_key_txtbox.Location = new Point(353, 524);
            security_key_txtbox.Margin = new Padding(3, 4, 3, 4);
            security_key_txtbox.Name = "security_key_txtbox";
            security_key_txtbox.PasswordChar = '\0';
            security_key_txtbox.PlaceholderForeColor = Color.Gray;
            security_key_txtbox.PlaceholderText = "Enter your key";
            security_key_txtbox.SelectedText = "";
            security_key_txtbox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            security_key_txtbox.Size = new Size(595, 60);
            security_key_txtbox.TabIndex = 10;
            // 
            // security_key_lbl
            // 
            security_key_lbl.AutoSize = true;
            security_key_lbl.BackColor = Color.Transparent;
            security_key_lbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            security_key_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            security_key_lbl.Location = new Point(365, 481);
            security_key_lbl.Name = "security_key_lbl";
            security_key_lbl.Size = new Size(240, 39);
            security_key_lbl.TabIndex = 9;
            security_key_lbl.Text = "Security Key: ";
            // 
            // admin_login_btn
            // 
            admin_login_btn.BackColor = Color.FromArgb(57, 131, 120);
            admin_login_btn.BorderColor = Color.Beige;
            admin_login_btn.BorderRadius = 34;
            admin_login_btn.Cursor = Cursors.Hand;
            admin_login_btn.CustomizableEdges = customizableEdges7;
            admin_login_btn.DisabledState.BorderColor = Color.DarkGray;
            admin_login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            admin_login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            admin_login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            admin_login_btn.FillColor = Color.FromArgb(49, 196, 141);
            admin_login_btn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_login_btn.ForeColor = Color.FromArgb(235, 216, 200);
            admin_login_btn.Location = new Point(353, 642);
            admin_login_btn.Name = "admin_login_btn";
            admin_login_btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            admin_login_btn.Size = new Size(595, 72);
            admin_login_btn.TabIndex = 11;
            admin_login_btn.Text = "Login";
            admin_login_btn.Click += admin_login_btn_Click;
            // 
            // forgot_password_btn
            // 
            forgot_password_btn.AutoSize = true;
            forgot_password_btn.BackColor = Color.Transparent;
            forgot_password_btn.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgot_password_btn.ForeColor = Color.FromArgb(235, 216, 200);
            forgot_password_btn.Location = new Point(735, 459);
            forgot_password_btn.Name = "forgot_password_btn";
            forgot_password_btn.Size = new Size(0, 24);
            forgot_password_btn.TabIndex = 12;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.Transparent;
            back_btn.Cursor = Cursors.Hand;
            back_btn.Image = Properties.Resources.fotor_2024092019277;
            back_btn.Location = new Point(12, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(70, 67);
            back_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            back_btn.TabIndex = 14;
            back_btn.TabStop = false;
            back_btn.Click += back_btn_Click;
            // 
            // cant_login_lbl
            // 
            cant_login_lbl.AutoSize = true;
            cant_login_lbl.BackColor = Color.Transparent;
            cant_login_lbl.Font = new Font("Microsoft Sans Serif", 12F);
            cant_login_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            cant_login_lbl.Location = new Point(528, 727);
            cant_login_lbl.Name = "cant_login_lbl";
            cant_login_lbl.Size = new Size(115, 25);
            cant_login_lbl.TabIndex = 16;
            cant_login_lbl.Text = "Can't login?";
            // 
            // forgot_password_lbl
            // 
            forgot_password_lbl.ActiveLinkColor = Color.Red;
            forgot_password_lbl.BackColor = Color.Transparent;
            forgot_password_lbl.Font = new Font("Microsoft Sans Serif", 12F);
            forgot_password_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            forgot_password_lbl.LinkColor = Color.FromArgb(235, 216, 200);
            forgot_password_lbl.Location = new Point(778, 470);
            forgot_password_lbl.Name = "forgot_password_lbl";
            forgot_password_lbl.Size = new Size(170, 25);
            forgot_password_lbl.TabIndex = 19;
            forgot_password_lbl.TabStop = true;
            forgot_password_lbl.Text = "Forgot password?";
            // 
            // contact_customs_btn
            // 
            contact_customs_btn.ActiveLinkColor = Color.RosyBrown;
            contact_customs_btn.BackColor = Color.Transparent;
            contact_customs_btn.Font = new Font("Microsoft Sans Serif", 12F);
            contact_customs_btn.LinkColor = Color.FromArgb(235, 216, 200);
            contact_customs_btn.Location = new Point(654, 727);
            contact_customs_btn.Name = "contact_customs_btn";
            contact_customs_btn.Size = new Size(170, 25);
            contact_customs_btn.TabIndex = 20;
            contact_customs_btn.TabStop = true;
            contact_customs_btn.Text = "Contact customs.";
            // 
            // admin_login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8;
            ClientSize = new Size(1300, 811);
            Controls.Add(contact_customs_btn);
            Controls.Add(forgot_password_lbl);
            Controls.Add(cant_login_lbl);
            Controls.Add(back_btn);
            Controls.Add(forgot_password_btn);
            Controls.Add(admin_login_btn);
            Controls.Add(security_key_txtbox);
            Controls.Add(security_key_lbl);
            Controls.Add(password_txtbox);
            Controls.Add(password_lbl);
            Controls.Add(username_txtbox);
            Controls.Add(username_lbl);
            Controls.Add(admin_login_lbl);
            Controls.Add(pictureBox1);
            Controls.Add(exit_btn);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admin_login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_login_page";
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)back_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox exit_btn;
        private PictureBox pictureBox1;
        private Label admin_login_lbl;
        private Label username_lbl;
        private Guna.UI2.WinForms.Guna2TextBox username_txtbox;
        private Guna.UI2.WinForms.Guna2TextBox password_txtbox;
        private Label password_lbl;
        private Guna.UI2.WinForms.Guna2TextBox security_key_txtbox;
        private Label security_key_lbl;
        private Guna.UI2.WinForms.Guna2Button admin_login_btn;
        private Label forgot_password_btn;
        private PictureBox back_btn;
        private Label cant_login_lbl;
        private LinkLabel forgot_password_lbl;
        private LinkLabel contact_customs_btn;
    }
}