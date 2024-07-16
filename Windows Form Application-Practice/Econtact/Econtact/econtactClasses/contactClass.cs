using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.econtactClasses
{
    internal class contactClass
    {
        //Getter-Setter Properties
        //Acts as Data Carrier in Our Application

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selecting data from database
        public DataTable Select()
        {
            //step1 - Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step2 - Writing SQL query
                string sql = "SELECT * FROM tbl_contact";
            }
            catch (Exception ex)
            {

            }
            finally 
            { 
            
            }
        }

    }
}
