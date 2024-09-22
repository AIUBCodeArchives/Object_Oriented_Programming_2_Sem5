namespace StudentDash.Forms
{
    partial class admin_panel_page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel_page));
            title_logo = new PictureBox();
            exit_btn = new PictureBox();
            pictureBox2 = new PictureBox();
            search_lbl = new Label();
            search_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            user_dataviewgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            admin_udate_btn = new Guna.UI2.WinForms.Guna2Button();
            admin_delete_btn = new Guna.UI2.WinForms.Guna2Button();
            signout_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)title_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_dataviewgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signout_btn).BeginInit();
            SuspendLayout();
            // 
            // title_logo
            // 
            title_logo.Image = Properties.Resources.Screenshot_2024_09_20_170500;
            title_logo.Location = new Point(476, 12);
            title_logo.Name = "title_logo";
            title_logo.Size = new Size(349, 98);
            title_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            title_logo.TabIndex = 1;
            title_logo.TabStop = false;
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
            exit_btn.TabIndex = 3;
            exit_btn.TabStop = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.fotor_2024092019277;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // search_lbl
            // 
            search_lbl.BackColor = Color.Transparent;
            search_lbl.Font = new Font("Mongolian Baiti", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            search_lbl.Location = new Point(85, 127);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(163, 44);
            search_lbl.TabIndex = 16;
            search_lbl.Text = "Search:";
            // 
            // search_txtbox
            // 
            search_txtbox.BackColor = Color.Transparent;
            search_txtbox.BorderColor = Color.FromArgb(201, 239, 199);
            search_txtbox.BorderRadius = 23;
            search_txtbox.CustomizableEdges = customizableEdges1;
            search_txtbox.DefaultText = "";
            search_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_txtbox.FillColor = Color.FromArgb(201, 239, 199);
            search_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_txtbox.Font = new Font("Segoe UI", 9F);
            search_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search_txtbox.Location = new Point(254, 127);
            search_txtbox.Margin = new Padding(3, 4, 3, 4);
            search_txtbox.Name = "search_txtbox";
            search_txtbox.PasswordChar = '\0';
            search_txtbox.PlaceholderForeColor = Color.Gray;
            search_txtbox.PlaceholderText = "Enter your key";
            search_txtbox.SelectedText = "";
            search_txtbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_txtbox.Size = new Size(962, 44);
            search_txtbox.TabIndex = 17;
            // 
            // user_dataviewgrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            user_dataviewgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            user_dataviewgrid.BackgroundColor = Color.FromArgb(235, 216, 200);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            user_dataviewgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            user_dataviewgrid.ColumnHeadersHeight = 4;
            user_dataviewgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            user_dataviewgrid.DefaultCellStyle = dataGridViewCellStyle3;
            user_dataviewgrid.GridColor = Color.FromArgb(231, 229, 255);
            user_dataviewgrid.Location = new Point(85, 192);
            user_dataviewgrid.Name = "user_dataviewgrid";
            user_dataviewgrid.RowHeadersVisible = false;
            user_dataviewgrid.RowHeadersWidth = 51;
            user_dataviewgrid.Size = new Size(1131, 481);
            user_dataviewgrid.TabIndex = 18;
            user_dataviewgrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            user_dataviewgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            user_dataviewgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            user_dataviewgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            user_dataviewgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            user_dataviewgrid.ThemeStyle.BackColor = Color.FromArgb(235, 216, 200);
            user_dataviewgrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            user_dataviewgrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            user_dataviewgrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            user_dataviewgrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            user_dataviewgrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            user_dataviewgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            user_dataviewgrid.ThemeStyle.HeaderStyle.Height = 4;
            user_dataviewgrid.ThemeStyle.ReadOnly = false;
            user_dataviewgrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            user_dataviewgrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            user_dataviewgrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            user_dataviewgrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            user_dataviewgrid.ThemeStyle.RowsStyle.Height = 29;
            user_dataviewgrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            user_dataviewgrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // admin_udate_btn
            // 
            admin_udate_btn.BackColor = Color.FromArgb(57, 131, 120);
            admin_udate_btn.BorderColor = Color.Beige;
            admin_udate_btn.BorderRadius = 34;
            admin_udate_btn.Cursor = Cursors.Hand;
            admin_udate_btn.CustomizableEdges = customizableEdges3;
            admin_udate_btn.DisabledState.BorderColor = Color.DarkGray;
            admin_udate_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            admin_udate_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            admin_udate_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            admin_udate_btn.FillColor = Color.FromArgb(49, 196, 141);
            admin_udate_btn.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_udate_btn.ForeColor = Color.FromArgb(235, 216, 200);
            admin_udate_btn.Location = new Point(85, 695);
            admin_udate_btn.Name = "admin_udate_btn";
            admin_udate_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            admin_udate_btn.Size = new Size(547, 72);
            admin_udate_btn.TabIndex = 19;
            admin_udate_btn.Text = "UPDATE";
            // 
            // admin_delete_btn
            // 
            admin_delete_btn.BackColor = Color.FromArgb(57, 131, 120);
            admin_delete_btn.BorderColor = Color.Beige;
            admin_delete_btn.BorderRadius = 34;
            admin_delete_btn.Cursor = Cursors.Hand;
            admin_delete_btn.CustomizableEdges = customizableEdges5;
            admin_delete_btn.DisabledState.BorderColor = Color.DarkGray;
            admin_delete_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            admin_delete_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            admin_delete_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            admin_delete_btn.FillColor = Color.FromArgb(49, 196, 141);
            admin_delete_btn.Font = new Font("Mongolian Baiti", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            admin_delete_btn.ForeColor = Color.FromArgb(235, 216, 200);
            admin_delete_btn.Location = new Point(669, 695);
            admin_delete_btn.Name = "admin_delete_btn";
            admin_delete_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            admin_delete_btn.Size = new Size(547, 72);
            admin_delete_btn.TabIndex = 20;
            admin_delete_btn.Text = "DELETE";
            // 
            // signout_btn
            // 
            signout_btn.BackColor = Color.FromArgb(57, 131, 120);
            signout_btn.Cursor = Cursors.Hand;
            signout_btn.Image = Properties.Resources.fotor_20240921194833;
            signout_btn.Location = new Point(1129, 12);
            signout_btn.Name = "signout_btn";
            signout_btn.Size = new Size(70, 67);
            signout_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            signout_btn.TabIndex = 49;
            signout_btn.TabStop = false;
            // 
            // admin_panel_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9;
            ClientSize = new Size(1300, 800);
            Controls.Add(signout_btn);
            Controls.Add(admin_delete_btn);
            Controls.Add(admin_udate_btn);
            Controls.Add(user_dataviewgrid);
            Controls.Add(search_txtbox);
            Controls.Add(search_lbl);
            Controls.Add(pictureBox2);
            Controls.Add(exit_btn);
            Controls.Add(title_logo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admin_panel_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_panel_page";
            ((System.ComponentModel.ISupportInitialize)title_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_dataviewgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)signout_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox title_logo;
        private PictureBox exit_btn;
        private PictureBox pictureBox2;
        private Label search_lbl;
        private Guna.UI2.WinForms.Guna2TextBox search_txtbox;
        private Guna.UI2.WinForms.Guna2DataGridView user_dataviewgrid;
        private Guna.UI2.WinForms.Guna2Button admin_udate_btn;
        private Guna.UI2.WinForms.Guna2Button admin_delete_btn;
        private PictureBox signout_btn;
    }
}