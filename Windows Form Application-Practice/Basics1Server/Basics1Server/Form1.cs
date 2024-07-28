using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basics1Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Window2_Click(object sender, EventArgs e)
        {

        }

        private void btnWindow2_Click(object sender, EventArgs e)
        {
            Window2.Visible = true;
            Window1.Visible = false;
            Window3.Visible = false;
            SubWindow1.Visible = false;
            SubWindow2.Visible = false;
            btnSubWindow1.Visible = false;
            btnSubWindow2.Visible = false;

        }

        private void btnWindow3_Click(object sender, EventArgs e)
        {
            Window3.Visible = true;
            Window2.Visible = false;
            Window1.Visible = false;
            SubWindow1.Visible = false;
            SubWindow2.Visible = false;
            btnSubWindow1.Visible = false;
            btnSubWindow2.Visible = false;
        }

        private void btnWindow1_Click(object sender, EventArgs e)
        {
            Window1.Visible = true;
            Window2.Visible = false;
            Window3.Visible = false;
            SubWindow1.Visible = true;
            SubWindow2.Visible = true;
            btnSubWindow1.Visible = true;
            btnSubWindow2.Visible = true;
        }

        private void btnSubWindow1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubWindow2_Click(object sender, EventArgs e)
        {

        }
    }
}
