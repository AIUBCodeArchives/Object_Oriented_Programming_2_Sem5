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
    public partial class user_login_page : Form
    {
        public user_login_page()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            login_page lp = new login_page();
            lp.Visible = true;
            this.Close();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            user_home_page uhp = new user_home_page();
            uhp.Visible = true;
            this.Close();
        }
    }
}
