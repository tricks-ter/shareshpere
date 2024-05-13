namespace shareshpere
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pndashboard = new System.Windows.Forms.Panel();
            this.btn_history = new System.Windows.Forms.Button();
            this.pnproject = new System.Windows.Forms.Panel();
            this.btn_project = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.feedback = new System.Windows.Forms.Button();
            this.pnlogout = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pndashboard.SuspendLayout();
            this.pnproject.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 57);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(834, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(67, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(199, 48);
            this.Title.TabIndex = 1;
            this.Title.Text = "ShareSpare";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 7);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(49, 40);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.pndashboard);
            this.sidebar.Controls.Add(this.pnproject);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.pnlogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 57);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(251, 482);
            this.sidebar.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 59);
            this.panel6.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-12, -36);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(290, 120);
            this.button4.TabIndex = 2;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pndashboard
            // 
            this.pndashboard.Controls.Add(this.btn_history);
            this.pndashboard.Location = new System.Drawing.Point(0, 75);
            this.pndashboard.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.pndashboard.Name = "pndashboard";
            this.pndashboard.Size = new System.Drawing.Size(263, 65);
            this.pndashboard.TabIndex = 3;
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_history.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.Color.White;
            this.btn_history.Image = global::shareshpere.Properties.Resources.icons8_history_32;
            this.btn_history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.Location = new System.Drawing.Point(-16, -31);
            this.btn_history.Name = "btn_history";
            this.btn_history.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_history.Size = new System.Drawing.Size(294, 125);
            this.btn_history.TabIndex = 2;
            this.btn_history.Text = "               History";
            this.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnproject
            // 
            this.pnproject.Controls.Add(this.btn_project);
            this.pnproject.Location = new System.Drawing.Point(0, 160);
            this.pnproject.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.pnproject.Name = "pnproject";
            this.pnproject.Size = new System.Drawing.Size(265, 65);
            this.pnproject.TabIndex = 3;
            // 
            // btn_project
            // 
            this.btn_project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_project.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_project.ForeColor = System.Drawing.Color.White;
            this.btn_project.Image = global::shareshpere.Properties.Resources.icons8_setting_32__3_;
            this.btn_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_project.Location = new System.Drawing.Point(-12, -36);
            this.btn_project.Name = "btn_project";
            this.btn_project.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_project.Size = new System.Drawing.Size(294, 118);
            this.btn_project.TabIndex = 2;
            this.btn_project.Text = "                Settings";
            this.btn_project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_project.UseVisualStyleBackColor = false;
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.feedback);
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 59);
            this.panel2.TabIndex = 3;
            // 
            // feedback
            // 
            this.feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.feedback.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback.ForeColor = System.Drawing.Color.White;
            this.feedback.Image = global::shareshpere.Properties.Resources.icons8_feedback_32__1_;
            this.feedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedback.Location = new System.Drawing.Point(-12, -36);
            this.feedback.Name = "feedback";
            this.feedback.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.feedback.Size = new System.Drawing.Size(290, 125);
            this.feedback.TabIndex = 2;
            this.feedback.Text = "                 Feedback";
            this.feedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedback.UseVisualStyleBackColor = false;
            this.feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // pnlogout
            // 
            this.pnlogout.Controls.Add(this.btn_logout);
            this.pnlogout.Location = new System.Drawing.Point(0, 324);
            this.pnlogout.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.pnlogout.Name = "pnlogout";
            this.pnlogout.Size = new System.Drawing.Size(265, 59);
            this.pnlogout.TabIndex = 3;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::shareshpere.Properties.Resources.icons8_logout_32;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(-10, -35);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(290, 125);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "                 Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            // 
            // UserDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(973, 539);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pndashboard.ResumeLayout(false);
            this.pnproject.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label Title;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Panel pndashboard;
        private System.Windows.Forms.Panel pnproject;
        private System.Windows.Forms.Button btn_project;
        private System.Windows.Forms.Panel pnlogout;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button feedback;
    }
}