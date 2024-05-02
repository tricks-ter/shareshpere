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

            string user_name, user_pass;
            
            user_name = user.Text;
            user_pass = pass.Text;
            


            try
            {

                


                string query = "SELECT * FROM users WHERE username = '" + user_name + "' AND password = '" + user_pass + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                
                sda.Fill(dt);
                

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("login successful", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else MessageBox.Show("Login Failed", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch(Exception ex) 
            {


                MessageBox.Show(ex.Message);


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

       

    }
}
