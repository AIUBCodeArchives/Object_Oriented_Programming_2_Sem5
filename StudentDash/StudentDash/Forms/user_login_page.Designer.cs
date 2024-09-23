namespace StudentDash.Forms
{
    partial class user_login_page
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
            pictureBox1 = new PictureBox();
            user_login_lbl = new Label();
            signup_btn = new LinkLabel();
            forgot_password_lbl = new LinkLabel();
            dont_have_account_lbl = new Label();
            admin_login_btn = new Guna.UI2.WinForms.Guna2Button();
            password_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            password_lbl = new Label();
            username_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            username_lbl = new Label();
            back_btn = new PictureBox();
            exit_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)back_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(57, 131, 120);
            pictureBox1.Image = Properties.Resources.icons8_user_64;
            pictureBox1.Location = new Point(586, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // user_login_lbl
            // 
            user_login_lbl.AutoSize = true;
            user_login_lbl.BackColor = Color.Transparent;
            user_login_lbl.Font = new Font("Microsoft Sans Serif", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_login_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            user_login_lbl.Location = new Point(568, 194);
            user_login_lbl.Name = "user_login_lbl";
            user_login_lbl.Size = new Size(165, 63);
            user_login_lbl.TabIndex = 5;
            user_login_lbl.Text = "Login";
            // 
            // signup_btn
            // 
            signup_btn.ActiveLinkColor = Color.RosyBrown;
            signup_btn.BackColor = Color.Transparent;
            signup_btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.LinkColor = Color.FromArgb(235, 216, 200);
            signup_btn.Location = new Point(720, 725);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(83, 25);
            signup_btn.TabIndex = 28;
            signup_btn.TabStop = true;
            signup_btn.Text = "Signup!";
            // 
            // forgot_password_lbl
            // 
            forgot_password_lbl.ActiveLinkColor = Color.Red;
            forgot_password_lbl.BackColor = Color.Transparent;
            forgot_password_lbl.Font = new Font("Microsoft Sans Serif", 12F);
            forgot_password_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            forgot_password_lbl.LinkColor = Color.FromArgb(235, 216, 200);
            forgot_password_lbl.Location = new Point(783, 561);
            forgot_password_lbl.Name = "forgot_password_lbl";
            forgot_password_lbl.Size = new Size(170, 25);
            forgot_password_lbl.TabIndex = 27;
            forgot_password_lbl.TabStop = true;
            forgot_password_lbl.Text = "Forgot password?";
            // 
            // dont_have_account_lbl
            // 
            dont_have_account_lbl.AutoSize = true;
            dont_have_account_lbl.BackColor = Color.Transparent;
            dont_have_account_lbl.Font = new Font("Microsoft Sans Serif", 12F);
            dont_have_account_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            dont_have_account_lbl.Location = new Point(497, 725);
            dont_have_account_lbl.Name = "dont_have_account_lbl";
            dont_have_account_lbl.Size = new Size(217, 25);
            dont_have_account_lbl.TabIndex = 26;
            dont_have_account_lbl.Text = "Don't have an account?";
            // 
            // admin_login_btn
            // 
            admin_login_btn.BackColor = Color.FromArgb(57, 131, 120);
            admin_login_btn.BorderColor = Color.Beige;
            admin_login_btn.BorderRadius = 34;
            admin_login_btn.Cursor = Cursors.Hand;
            admin_login_btn.CustomizableEdges = customizableEdges1;
            admin_login_btn.DisabledState.BorderColor = Color.DarkGray;
            admin_login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            admin_login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            admin_login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            admin_login_btn.FillColor = Color.FromArgb(49, 196, 141);
            admin_login_btn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_login_btn.ForeColor = Color.FromArgb(235, 216, 200);
            admin_login_btn.Location = new Point(353, 640);
            admin_login_btn.Name = "admin_login_btn";
            admin_login_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            admin_login_btn.Size = new Size(595, 72);
            admin_login_btn.TabIndex = 25;
            admin_login_btn.Text = "Login";
            admin_login_btn.Click += admin_login_btn_Click;
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
            password_txtbox.Location = new Point(353, 497);
            password_txtbox.Margin = new Padding(3, 4, 3, 4);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.PlaceholderForeColor = Color.Gray;
            password_txtbox.PlaceholderText = "Enter your password";
            password_txtbox.SelectedText = "";
            password_txtbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password_txtbox.Size = new Size(595, 60);
            password_txtbox.TabIndex = 24;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.BackColor = Color.Transparent;
            password_lbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            password_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            password_lbl.Location = new Point(370, 454);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(185, 39);
            password_lbl.TabIndex = 23;
            password_lbl.Text = "Password:";
            // 
            // username_txtbox
            // 
            username_txtbox.BackColor = Color.Transparent;
            username_txtbox.BorderColor = Color.FromArgb(201, 239, 199);
            username_txtbox.BorderRadius = 27;
            username_txtbox.CustomizableEdges = customizableEdges5;
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
            username_txtbox.Location = new Point(353, 357);
            username_txtbox.Margin = new Padding(3, 4, 3, 4);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.PasswordChar = '\0';
            username_txtbox.PlaceholderForeColor = Color.Gray;
            username_txtbox.PlaceholderText = "Enter your name";
            username_txtbox.SelectedText = "";
            username_txtbox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            username_txtbox.Size = new Size(595, 60);
            username_txtbox.TabIndex = 22;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            username_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            username_lbl.Location = new Point(370, 314);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(363, 39);
            username_lbl.TabIndex = 21;
            username_lbl.Text = "Username/StudentID:";
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.Transparent;
            back_btn.Cursor = Cursors.Hand;
            back_btn.Image = Properties.Resources.fotor_2024092019277;
            back_btn.Location = new Point(12, 26);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(70, 67);
            back_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            back_btn.TabIndex = 30;
            back_btn.TabStop = false;
            back_btn.Click += back_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.FromArgb(57, 131, 120);
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.Image = Properties.Resources.icons8_cross_40;
            exit_btn.Location = new Point(1218, 26);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(70, 67);
            exit_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            exit_btn.TabIndex = 29;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // user_login_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8;
            ClientSize = new Size(1300, 800);
            Controls.Add(back_btn);
            Controls.Add(exit_btn);
            Controls.Add(signup_btn);
            Controls.Add(forgot_password_lbl);
            Controls.Add(dont_have_account_lbl);
            Controls.Add(admin_login_btn);
            Controls.Add(password_txtbox);
            Controls.Add(password_lbl);
            Controls.Add(username_txtbox);
            Controls.Add(username_lbl);
            Controls.Add(user_login_lbl);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "user_login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "user_login_page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)back_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label user_login_lbl;
        private LinkLabel signup_btn;
        private LinkLabel forgot_password_lbl;
        private Label dont_have_account_lbl;
        private Guna.UI2.WinForms.Guna2Button admin_login_btn;
        private Guna.UI2.WinForms.Guna2TextBox password_txtbox;
        private Label password_lbl;
        private Guna.UI2.WinForms.Guna2TextBox username_txtbox;
        private Label username_lbl;
        private PictureBox back_btn;
        private PictureBox exit_btn;
    }
}