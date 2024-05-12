using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shareshpere
{
    public partial class Dashboard : Form
    {
        fromdashboard dash;
        bool sidebarExapand = false;
        private Panel pnTop;
        fromusers users;
        fromproject project;

        public Dashboard()
        {
            InitializeComponent();
            pnTop = new Panel();
        }

       





        private void Dashboard_Load(object sender, EventArgs e)
        {
            sidebar.Width = 55;
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            const int targetCollapsedWidth = 55;
            const int targetExpandedWidth = 251;
            const int step = 10;

            if (sidebarExapand)
            {
                if (sidebar.Width < targetExpandedWidth)
                {
                    sidebar.Width += step;
                }
                else
                {
                    sidebar.Width = targetExpandedWidth;
                    sidebarExapand = false;
                    sidebarTransition.Stop();
                    pndashboard.Width = sidebar.Width;
                    pnproject.Width = sidebar.Width;
                    pnusers.Width = sidebar.Width;
                    pnlogout.Width = sidebar.Width;
                }
            }
            else
            {
                if (sidebar.Width > targetCollapsedWidth)
                {
                    sidebar.Width -= step;
                }
                else
                {
                    sidebar.Width = targetCollapsedWidth;
                    sidebarExapand = true;
                    sidebarTransition.Stop();
                    pndashboard.Width = sidebar.Width;
                    pnproject.Width = sidebar.Width;
                    pnusers.Width = sidebar.Width;
                    pnlogout.Width = sidebar.Width;


                }
            }
        }


        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if(dash == null)
            {
                dash = new fromdashboard();
                dash.FormClosed += Dashboard_FromClosed;
                dash.MdiParent = this;
                dash.Dock = DockStyle.Fill;
                dash.Show();

            }
            else
            {
                dash.Activate();
            }
            


        }
        private void Dashboard_FromClosed(object sender, FormClosedEventArgs e)
        {
             dash = null; 
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (users == null)
            {
                users = new fromusers();
                users.FormClosed += Users_FromClosed;
                users.MdiParent = this;
                users.Dock = DockStyle.Fill;
                users.Show();

            }
            else
            {
                users.Activate();
            }
        }
        private void Users_FromClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (project == null)
            {
                project = new fromproject();
                project.FormClosed += Project_FromClosed;
                project.MdiParent = this;
                project.Dock = DockStyle.Fill;
                project.Show();

            }
            else
            {
                project.Activate();
            }
        }
        private void Project_FromClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            UserSessionManager.Instance.ClearSession();
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

