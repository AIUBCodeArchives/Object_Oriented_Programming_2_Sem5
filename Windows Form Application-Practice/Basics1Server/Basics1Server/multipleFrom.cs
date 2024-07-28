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
    public partial class multipleFrom : Form
    {
        public multipleFrom()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadForm(Object Form)
        {
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill; 
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new dashboardForm());
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            LoadForm(new employeeForm());
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            LoadForm(new reportsForm());
        }
    }
}
