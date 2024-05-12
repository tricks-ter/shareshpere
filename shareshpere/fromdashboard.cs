using ReaLTaiizor.Util;
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

        private int GetNumberOfProjects()
        {
            int numberOfProjects = 0;
            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Project";

                SqlCommand command = new SqlCommand(query, conn);

                numberOfProjects = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the number of projects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return numberOfProjects;
        }
        private decimal Gettargetfund()
        {
            decimal totalFundsRaised = 0;
            
            try
            {
                conn.Open();

                string query = "SELECT FundTarget FROM Project WHERE IsCurrent = 'True'";

                SqlCommand command = new SqlCommand(query, conn);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalFundsRaised = Convert.ToDecimal(result);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total funds raised: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return totalFundsRaised;
        }

        private decimal GetTotalFundsRaised()
        {
            decimal totalFundsRaised = 0;
            
            try
            {
                conn.Open();

                string query = "SELECT SUM(FundRaised) FROM Project WHERE IsCurrent = 'True'";

                SqlCommand command = new SqlCommand(query, conn);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalFundsRaised = Convert.ToDecimal(result);
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the total funds raised: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return totalFundsRaised;
        }

        private void fromdashboard_Load(object sender, EventArgs e)
        {
            GetNumberOfUsers();
            usernum.Text = numberOfUsers.ToString();
            int numberOfProjects = GetNumberOfProjects();
            projectnum.Text = numberOfProjects.ToString() + " project have been created!!";
            decimal totalFundsRaised = GetTotalFundsRaised();
            decimal targetFunds = Gettargetfund();
            fundraised.Text = totalFundsRaised + "$ has been raised!!!";
            decimal Percent = (totalFundsRaised / targetFunds) *100 ;
            
            circlefundbar.percentage = Convert.ToInt32(Math.Round( Percent));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
