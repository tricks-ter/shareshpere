using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shareshpere
{
    public partial class UserDashboard : Form
    {
        Feeds feed;
        settings seting;
        history history;
        bool sidebarExapand = false;


        public UserDashboard()
        {
            InitializeComponent();

        }


        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (history == null)
            {
                history = new history();
                history.FormClosed += History_FromClosed;
                history.MdiParent = this;
                history.Dock = DockStyle.Fill;
                history.Show();

            }
            else
            {
                history.Activate();
            }
        }
        private void History_FromClosed(object sender, FormClosedEventArgs e)
        {
            history = null;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_project_Click(object sender, EventArgs e)
        {

            if (seting == null)
            {
                seting = new settings();
                seting.FormClosed += Settings_FromClosed;
                seting.MdiParent = this;
                seting.Dock = DockStyle.Fill;
                seting.Show();

            }
            else
            {
                seting.Activate();
            }


        }
    
    private void Settings_FromClosed(object sender, FormClosedEventArgs e)
        {
            seting = null;
        }
    

        private void btn_logout_Click(object sender, EventArgs e)
        {
            UserSessionManager.Instance.ClearSession();
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    

        private void btnHam_Click(object sender, EventArgs e)
        {


           
        }
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            sidebar.Width = 55;
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {


            if (feed == null)
            {
                feed = new Feeds();
                feed.FormClosed += Feed_FromClosed;
                feed.MdiParent = this;
                feed.Dock = DockStyle.Fill;
                feed.Show();

            }
            else
            {
                feed.Activate();
            }


        }
        private void Feed_FromClosed(object sender, FormClosedEventArgs e)
        {
            feed = null;
        }
    }
}

