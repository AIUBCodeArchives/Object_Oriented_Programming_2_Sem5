using System;
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
    public partial class user_home_page : Form
    {
        public user_home_page()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Visible = true;
            this.Close();
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            login_page lp = new login_page();
            lp.Visible = true;
            this.Close();
        }
    }
}
