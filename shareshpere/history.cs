using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shareshpere
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            // Step 1: Retrieve userID from session
            int userID = UserSessionManager.Instance.userID;

            // Step 2: Fetch data from Donations table for the specific userID
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT DonationID, ProjectID, Amount, DonationDateTime FROM Donations WHERE userID = @userID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userID", userID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                    history_data.DataSource = dataTable; // Step 3: Populate DataGridView
                }
                else
                {
                    MessageBox.Show("No donation history found for this user.");
                }
            }
        }
    }
}
