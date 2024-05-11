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

namespace shareshpere
{
    public partial class fromdashboard : Form
    {
        public fromdashboard()
        {
            InitializeComponent();
        }
        int numberOfUsers = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L2B1K6F\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False;");
        private int GetNumberOfUsers()
        {
            

            try
            {
                
                conn.Open();

                
                string query = "SELECT COUNT(*) FROM users";

                
                SqlCommand command = new SqlCommand(query, conn);

                
                numberOfUsers = (int)command.ExecuteScalar();


            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred while retrieving the number of users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                conn.Close();
            }

            return numberOfUsers;
        }
        private void fromdashboard_Load(object sender, EventArgs e)
        {
            GetNumberOfUsers();
            usernum.Text = numberOfUsers.ToString();
            
        }
    }
}
