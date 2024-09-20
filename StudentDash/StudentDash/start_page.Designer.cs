namespace StudentDash
{
    partial class start_page
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_page));
            title_logo = new PictureBox();
            title_info_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            load_progressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            progressbar_timer = new System.Windows.Forms.Timer(components);
            progressbar_percentage_lbl = new Label();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)title_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // title_logo
            // 
            title_logo.Image = Properties.Resources.Screenshot_2024_09_20_170500;
            title_logo.Location = new Point(337, 302);
            title_logo.Name = "title_logo";
            title_logo.Size = new Size(627, 196);
            title_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            title_logo.TabIndex = 0;
            title_logo.TabStop = false;
            // 
            // title_info_lbl
            // 
            title_info_lbl.BackColor = Color.Transparent;
            title_info_lbl.Font = new Font("Modern No. 20", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_info_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            title_info_lbl.Location = new Point(469, 442);
            title_info_lbl.Name = "title_info_lbl";
            title_info_lbl.Size = new Size(452, 43);
            title_info_lbl.TabIndex = 1;
            title_info_lbl.Text = "Campus to home in one go.";
            title_info_lbl.TextAlignment = ContentAlignment.TopCenter;
            // 
            // load_progressbar
            // 
            load_progressbar.CustomizableEdges = customizableEdges1;
            load_progressbar.FillColor = SystemColors.Control;
            load_progressbar.Location = new Point(100, 675);
            load_progressbar.Name = "load_progressbar";
            load_progressbar.ProgressColor = Color.FromArgb(49, 196, 141);
            load_progressbar.ProgressColor2 = Color.FromArgb(49, 196, 141);
            load_progressbar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            load_progressbar.Size = new Size(1100, 40);
            load_progressbar.TabIndex = 2;
            load_progressbar.Text = "guna2ProgressBar1";
            load_progressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // progressbar_timer
            // 
            progressbar_timer.Tick += progressbar_timer_Tick;
            // 
            // progressbar_percentage_lbl
            // 
            progressbar_percentage_lbl.AutoSize = true;
            progressbar_percentage_lbl.BackColor = Color.Transparent;
            progressbar_percentage_lbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressbar_percentage_lbl.ForeColor = Color.FromArgb(235, 216, 200);
            progressbar_percentage_lbl.Location = new Point(1051, 624);
            progressbar_percentage_lbl.Name = "progressbar_percentage_lbl";
            progressbar_percentage_lbl.Size = new Size(66, 21);
            progressbar_percentage_lbl.TabIndex = 3;
            progressbar_percentage_lbl.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_car_unscreen;
            pictureBox1.Location = new Point(1123, 599);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(235, 216, 200);
            guna2HtmlLabel1.Location = new Point(536, 757);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(228, 31);
            guna2HtmlLabel1.TabIndex = 5;
            guna2HtmlLabel1.Text = "All rights reserved";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopCenter;
            // 
            // start_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9;
            ClientSize = new Size(1300, 800);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(progressbar_percentage_lbl);
            Controls.Add(load_progressbar);
            Controls.Add(title_info_lbl);
            Controls.Add(title_logo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "start_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "start_page";
            Load += start_page_Load;
            ((System.ComponentModel.ISupportInitialize)title_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox title_logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel title_info_lbl;
        private Guna.UI2.WinForms.Guna2ProgressBar load_progressbar;
        private System.Windows.Forms.Timer progressbar_timer;
        private Label progressbar_percentage_lbl;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
