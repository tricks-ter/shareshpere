using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace shareshpere
{
    public partial class Dashboard : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
           
        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlnav.Height = btnDashboard.Height;
            pnlnav.Top = btnDashboard.Top;
            pnlnav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            pnlnav.Height = btnDashboard.Height;
            pnlnav.Top = btnDashboard.Top;
            pnlnav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            
        }

        private void btnAnalytics_click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlnav.Height = btnAnalysis.Height;
            pnlnav.Top = btnAnalysis.Top;
            pnlnav.Left = btnAnalysis.Left;
            btnAnalysis.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlnav.Height = btnProject.Height;
            pnlnav.Top = btnProject.Top;
            pnlnav.Left = btnProject.Left;
            btnProject.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            pnlnav.Height = btnSettings.Height;
            pnlnav.Top = btnSettings.Top;
            pnlnav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24,30,54 );
        }

        private void btnAnalysis_Leave(object sender, EventArgs e)
        {
            btnAnalysis.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProject_Leave(object sender, EventArgs e)
        {

            btnProject.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
 }
    


