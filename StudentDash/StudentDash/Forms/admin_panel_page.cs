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
    public partial class admin_panel_page : Form
    {
        public admin_panel_page()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}