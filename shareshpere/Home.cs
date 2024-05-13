using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace shareshpere
{
    public partial class Home : Form
    {
        private Timer animationTimer = new Timer();
        private const int AnimationStep = 5;
        private const int PaymentPanelHeight = 216;
        private bool isPanelOpen = false;
        private int paymentPanelYStart;
        private int paymentPanelYEnd;

        public Home()
        {
            InitializeComponent();
            InitializeAnimationTimer();
            InitializePaymentPanel();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer.Interval = 20;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void InitializePaymentPanel()
        {
            paymentPanelYStart = -PaymentPanelHeight;
            paymentPanelYEnd = 3;
            paymentpanel.Size = new Size(491, PaymentPanelHeight);
            paymentpanel.Location = new Point(131, paymentPanelYStart);

            
            
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (isPanelOpen)
            {
                if (paymentpanel.Top < paymentPanelYEnd)
                {
                    paymentpanel.Top += AnimationStep;
                }
                else
                {
                    animationTimer.Stop();
                }
            }
            else
            {
                if (paymentpanel.Top > paymentPanelYStart)
                {
                    paymentpanel.Top -= AnimationStep;
                }
                else
                {
                    paymentpanel.Visible = false;
                    animationTimer.Stop();
                }
            }
        }

        private void donet_Click(object sender, EventArgs e)
        {
            isPanelOpen = !isPanelOpen;
            animationTimer.Start();
            paymentpanel.Visible = isPanelOpen;
        }

        private void bank_Click(object sender, EventArgs e)
        {
            Donate("Bank");
        }

        private void bkash_Click(object sender, EventArgs e)
        {
            Donate("Bkash");
        }

        private void nagad_Click(object sender, EventArgs e)
        {
            Donate("Nagad");
        }

        private void Donate(string paymentMethod)
        {
            int userID = GetUserIDFromSession();
            if (userID == 0)
            {
                MessageBox.Show("Failed to retrieve user ID from session.");
                return;
            }

            int projectID = GetLatestProjectID();
            if (projectID == 0)
            {
                MessageBox.Show("No projects found.");
                return;
            }

            decimal amount = GetDonationAmount();
            if (amount <= 0)
            {
                MessageBox.Show("Invalid donation amount.");
                return;
            }

            string donationID = GenerateDonationID();
            DateTime donationDateTime = DateTime.Now;

            if (InsertDonationRecord(donationID, userID, projectID, amount, donationDateTime) &&
                UpdateProjectFundRaised(projectID, amount))
            {
                MessageBox.Show("Donation Successful! Thank you for your contribution.");
            }
            else
            {
                MessageBox.Show("Failed to process donation.");
            }
        }

        private int GetUserIDFromSession()
        {
            return UserSessionManager.Instance.userID;
        }

        private int GetLatestProjectID()
        {
            int projectID = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                string query = "SELECT TOP 1 ProjectID FROM Project ORDER BY ProjectID DESC";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    projectID = Convert.ToInt32(result);
                }
            }
            return projectID;
        }

        private decimal GetDonationAmount()
        {
            decimal amount = 0;
            if (decimal.TryParse(money.Text, out amount))
            {
                return amount;
            }
            return 0;
        }

        private bool InsertDonationRecord(string donationID, int userID, int projectID, decimal amount, DateTime donationDateTime)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "INSERT INTO Donations (DonationID, userID, ProjectID, Amount, DonationDateTime) VALUES (@donationID, @userID, @projectID, @amount, @donationDateTime)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@donationID", donationID);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@projectID", projectID);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@donationDateTime", donationDateTime);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting donation record: " + ex.Message);
                return false;
            }
        }

        private bool UpdateProjectFundRaised(int projectID, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "UPDATE Project SET FundRaised = FundRaised + @amount WHERE ProjectID = @projectID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@projectID", projectID);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating project fund raised: " + ex.Message);
                return false;
            }
        }

        private string GenerateDonationID()
        {
            return Guid.NewGuid().ToString();
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
            sethome();
        }
        private void sethome()
        {
            int projectID;
            string projectTitle;
            string projectDescription;
            byte[] imageBytes = null; // Variable to store binary image data

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                string query = "SELECT TOP 1 ProjectID, Title, Description, Image FROM Project ORDER BY ProjectID DESC";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    projectID = reader.GetInt32(0);
                    projectTitle = reader.GetString(1);
                    projectDescription = reader.GetString(2);
                    imageBytes = (byte[])reader["Image"]; // Retrieve binary image data
                    project_name.Text = projectTitle;
                    proID.Text = Convert.ToString(projectID);
                    description.Text = projectDescription;
                }
                else
                {
                    MessageBox.Show("No projects found.");
                    return;
                }
            }

            // Convert binary image data to Image object
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    // Set the image to the PictureBox control
                    projectimg.Image = image;
                }
            }
            else
            {
                MessageBox.Show("No image found for the project.");
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            if(UserSessionManager.Instance.isAdmin == "True")
            {
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                UserDashboard user = new UserDashboard();
                this.Hide();
                user.Show();
            }
        }
    }
}
