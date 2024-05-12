using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace shareshpere
{
    public partial class fromproject : Form
    {
        private string connectionString = "Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Initial Catalog=ShareSphere;Integrated Security=True;Encrypt=False;";

        public fromproject()
        {
            InitializeComponent();
        }
        private void fromproject_Load(object sender, EventArgs e)
        {
            
        }


        private void btn_createproject_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkTableQuery = "IF OBJECT_ID('Project', 'U') IS NULL BEGIN " +
                                             "CREATE TABLE Project (" +
                                             "ProjectID INT PRIMARY KEY IDENTITY," +
                                             "Title NVARCHAR(100)," +
                                             "Description NVARCHAR(MAX)," +
                                             "Image VARBINARY(MAX)," +
                                             "FundTarget DECIMAL(18, 2)," +
                                             "FundRaised DECIMAL(18, 2)," +
                                             "IsCurrent NVARCHAR(100)," +
                                             ") END";

                    SqlCommand checkTableCommand = new SqlCommand(checkTableQuery, connection);
                    checkTableCommand.ExecuteNonQuery();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    byte[] imageBytes = null;
                    if (picture.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        picture.Image.Save(ms, picture.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    string insertQuery = @"INSERT INTO Project (Title, Description, Image, FundTarget, FundRaised, Iscurrent) 
                                           VALUES (@Title, @Description, @Image, @FundTarget, @FundRaised, @IsCurrent)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@Title", title.Text);
                    command.Parameters.AddWithValue("@Description", description.Text);
                    command.Parameters.AddWithValue("@Image", imageBytes);
                    command.Parameters.AddWithValue("@FundTarget", Convert.ToDecimal(target_fund.Text));
                    command.Parameters.AddWithValue("@FundRaised", 0.00);
                    command.Parameters.AddWithValue("@IsCurrent", current_checker.Checked);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Project created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create project!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
