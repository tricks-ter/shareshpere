using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shareshpere
{
    public partial class Feeds : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False;";
        private int userID;
        private string username;

        public Feeds()
        {
            InitializeComponent();
            userID = GetUserSessionID();
            username = GetUserSessionUsername();
            Console.WriteLine(userID + " " + username);
        }

        private void give_feedback_Click(object sender, EventArgs e)
        {
            int projectID;
            if (!int.TryParse(projectid.Text, out projectID))
            {
                MessageBox.Show("Please enter a valid Project ID.");
                return;
            }

            string feedbackText = feedbacks.Text;
            DateTime dateTime = DateTime.Now;

            string query = "INSERT INTO Feedback (UserID, Username, FeedbackText, DateTime, ProjectID) VALUES (@UserID, @Username, @FeedbackText, @DateTime, @ProjectID)";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@FeedbackText", feedbackText);
                command.Parameters.AddWithValue("@DateTime", dateTime);
                command.Parameters.AddWithValue("@ProjectID", projectID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Feedback submitted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit feedback.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int GetUserSessionID()
        {
            return UserSessionManager.Instance.userID; // Assuming UserSessionManager is correctly implemented
        }

        private string GetUserSessionUsername()
        {
            return UserSessionManager.Instance.username; // Assuming UserSessionManager is correctly implemented
        }
    }
}
