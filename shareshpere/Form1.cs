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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L2B1K6F\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False;");
        private void login_btn_Click(object sender, EventArgs e)
        {
            string user_name = user.Text;
            string user_pass = pass.Text;

            try
            {
                conn.Open();

                string query = "SELECT UserID, Username, Email, IsAdmin FROM users WHERE username = @Username AND password = @Password";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", user_name);
                command.Parameters.AddWithValue("@Password", user_pass);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    int userID = (int)reader["UserID"];
                    string username = (string)reader["Username"];
                    string email = (string)reader["Email"];
                    string isAdmin = reader["IsAdmin"] == DBNull.Value ? string.Empty : (string)reader["IsAdmin"];


                    UserSessionManager.Instance.userID = userID;
                    UserSessionManager.Instance.username = username;
                    UserSessionManager.Instance.email = email;
                    UserSessionManager.Instance.isAdmin = isAdmin;


                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            Register R1 = new Register();
            this.Hide();
            R1.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        
    }
}
