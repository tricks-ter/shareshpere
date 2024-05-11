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
        public Dashboard()
        {
            InitializeComponent();
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
            }
        }
    }
}
