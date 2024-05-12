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
using Xamarin.Forms;

namespace shareshpere
{
    public partial class fromusers : Form
    {
        string connectionString = @"Data Source=DESKTOP-L2B1K6F\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False;";

        public fromusers()
        {
            InitializeComponent();
        }

        private void poisonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fromusers_Load(object sender, EventArgs e)
        {
            PopulateUserDataGrid();

        }
        private void PopulateUserDataGrid()
        {
            try
            {
                string query = "SELECT * FROM users";

                 using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable usersTable = new DataTable();

                    
                    adapter.Fill(usersTable);

                    
                    userdata.DataSource = usersTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
               string query = "SELECT * FROM users WHERE username LIKE @keyword OR email LIKE @keyword";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                  SqlCommand cmd = new SqlCommand(query, conn);

                   cmd.Parameters.AddWithValue("@keyword", "%" + searchbox.Text + "%");

                   SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable usersTable = new DataTable();

                    adapter.Fill(usersTable);

                   userdata.DataSource = usersTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
