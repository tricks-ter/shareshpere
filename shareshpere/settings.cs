using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shareshpere
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void username_update_Click(object sender, EventArgs e)
        {
            UpdateUser("Username", nusername.Text);
        }

        private void password_update_Click(object sender, EventArgs e)
        {
            UpdateUser("Password", npassword.Text);
        }

        private void email_update_Click(object sender, EventArgs e)
        {
            UpdateUser("Email", nemail.Text);
        }

        private void UpdateUser(string columnName, string newValue)
        {
            int userID = UserSessionManager.Instance.userID; 
            string connectionString = "Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False;";
            string query = $"UPDATE Users SET {columnName} = @NewValue WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewValue", newValue);
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user information.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void settings_Load(object sender, EventArgs e)
        {

        }
    }
}
