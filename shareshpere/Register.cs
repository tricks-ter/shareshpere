using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shareshpere
{
    public partial class Register : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Register()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DESKTOP-L2B1K6F\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                if (password.Text == password_con.Text)
                {
                    // Parameterized query to prevent SQL injection
                    string query = "INSERT INTO users (username, email, password, reg_date) VALUES (@username, @email, @password, @reg_date)";
                    cmd.CommandText = query;

                    // Clear existing parameters before adding new ones
                    cmd.Parameters.Clear();

                    // Add parameters
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.Parameters.AddWithValue("@reg_date", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();

                    // Clear fields after successful insertion
                    username.Clear();
                    email.Clear();
                    password.Clear();
                    password_con.Clear();

                    MessageBox.Show("User successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                else
                {
                    MessageBox.Show("Password Did not Match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void loginpage_Click(object sender, EventArgs e)
        {
            shareshpere.Login R2 = new Login();
            this.Hide();
            R2.Show();
        }

        private void dash_Click(object sender, EventArgs e)
        {
            shareshpere.Dashboard Du = new Dashboard();
            this.Hide();
            Du.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
