using Econtact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();

        private void txtboxContactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbboxGender_Click(object sender, EventArgs e)
        {

        }

        

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the value from the input field 
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = comboBoxGender.Text;
            //inserting data into database using methods in contactClass
            bool success = c.Insert(c);
            if(success == true)
            {
                //inserted 
                MessageBox.Show("New Contact Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new contact. Try again");
            }

            //Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the data from the textBoxes
            c.ContactID = Convert.ToInt32(txtbocContactID.Text);
            bool success = c.Delete(c);

            if (success == true)
            {
                //inserted 
                MessageBox.Show("Contact Deleted");
                //Load Data on Data Gridview
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete new contact. Try again");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbocContactID.Text = "";
            Clear();
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            //Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to clear all the fields
        public void Clear()
        {
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContactNumber.Text = "";
            txtboxAddress.Text = "";
            comboBoxGender.Text = "";
        }

        //mistake - NO USE
        private void txtboxContactNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the data from the textboxes
            c.ContactID = Convert.ToInt32(txtbocContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbboxGender.Text;

            bool success = c.Update(c);

            if (success)
            {
                MessageBox.Show("Updated Successfully!");
                //Load Data on Data Gridview
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Call clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Contact. Please try again");
            }
        }
        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from Data Grid view into the Textboxes 
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtbocContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void txtbocContactID_TextChanged(object sender, EventArgs e)
        {

        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textbox
            string keyword = txtboxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%"+keyword+"%' OR LastName LIKE '%"+keyword+"%' OR Address LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}
