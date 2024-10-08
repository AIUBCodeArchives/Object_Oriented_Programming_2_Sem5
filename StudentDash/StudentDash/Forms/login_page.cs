﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDash.Forms
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            admin_login_page alp = new admin_login_page();
            alp.Visible = true;
            this.Close();
        }

        private void user_login_btn_Click(object sender, EventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Show();
            this.Visible = false;
        }
    }
}
