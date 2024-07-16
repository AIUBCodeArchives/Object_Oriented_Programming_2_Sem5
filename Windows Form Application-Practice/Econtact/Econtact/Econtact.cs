using Econtact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
            else
            {
                MessageBox.Show("Failed to add new contact. Try again");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
