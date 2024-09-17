using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                if (con.State != ConnectionState.Open)
                {
                    MessageBox.Show("Connection Successful");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox3.Text);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Connection Unsuccessful");
                }
            }
            catch(Exception ex) 
            {
            
            }
        }
    }
}
