namespace shareshpere
{
    partial class Feeds
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
            this.project_id = new ReaLTaiizor.Controls.BigLabel();
            this.projectid = new ReaLTaiizor.Controls.DungeonTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.feedbacks = new ReaLTaiizor.Controls.DungeonRichTextBox();
            this.give_feedback = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.SuspendLayout();
            // 
            // project_id
            // 
            this.project_id.AutoSize = true;
            this.project_id.BackColor = System.Drawing.Color.Transparent;
            this.project_id.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.project_id.Location = new System.Drawing.Point(12, 20);
            this.project_id.Name = "project_id";
            this.project_id.Size = new System.Drawing.Size(175, 45);
            this.project_id.TabIndex = 0;
            this.project_id.Text = "ProjectID : ";
            // 
            // projectid
            // 
            this.projectid.BackColor = System.Drawing.Color.Transparent;
            this.projectid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.projectid.EdgeColor = System.Drawing.Color.White;
            this.projectid.Font = new System.Drawing.Font("Tahoma", 11F);
            this.projectid.ForeColor = System.Drawing.Color.DimGray;
            this.projectid.Location = new System.Drawing.Point(208, 28);
            this.projectid.MaxLength = 32767;
            this.projectid.Multiline = false;
            this.projectid.Name = "projectid";
            this.projectid.ReadOnly = false;
            this.projectid.Size = new System.Drawing.Size(466, 37);
            this.projectid.TabIndex = 1;
            this.projectid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectid.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(12, 96);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(180, 45);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Feedback : ";
            // 
            // feedbacks
            // 
            this.feedbacks.AutoWordSelection = false;
            this.feedbacks.BackColor = System.Drawing.Color.Transparent;
            this.feedbacks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.feedbacks.EdgeColor = System.Drawing.Color.White;
            this.feedbacks.Font = new System.Drawing.Font("Tahoma", 10F);
            this.feedbacks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.feedbacks.Location = new System.Drawing.Point(208, 110);
            this.feedbacks.Name = "feedbacks";
            this.feedbacks.ReadOnly = false;
            this.feedbacks.Size = new System.Drawing.Size(466, 195);
            this.feedbacks.TabIndex = 2;
            this.feedbacks.TextBackColor = System.Drawing.Color.White;
            this.feedbacks.WordWrap = true;
            // 
            // give_feedback
            // 
            this.give_feedback.BackColor = System.Drawing.Color.Transparent;
            this.give_feedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.give_feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.give_feedback.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.give_feedback.Image = null;
            this.give_feedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.give_feedback.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.give_feedback.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.give_feedback.Location = new System.Drawing.Point(354, 333);
            this.give_feedback.Name = "give_feedback";
            this.give_feedback.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.give_feedback.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.give_feedback.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.give_feedback.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.give_feedback.Size = new System.Drawing.Size(177, 40);
            this.give_feedback.TabIndex = 3;
            this.give_feedback.Text = "Give Feedback";
            this.give_feedback.TextAlignment = System.Drawing.StringAlignment.Center;
            this.give_feedback.Click += new System.EventHandler(this.give_feedback_Click);
            // 
            // Feeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.give_feedback);
            this.Controls.Add(this.feedbacks);
            this.Controls.Add(this.projectid);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.project_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Feeds";
            this.Text = "Feeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel project_id;
        private ReaLTaiizor.Controls.DungeonTextBox projectid;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonRichTextBox feedbacks;
        private ReaLTaiizor.Controls.DungeonButtonLeft give_feedback;
    }
}