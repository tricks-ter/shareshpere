namespace shareshpere
{
    partial class fromproject
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.target_fund = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.description = new ReaLTaiizor.Controls.RichTextBoxEdit();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.title = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.btn_createproject = new System.Windows.Forms.Button();
            this.current_checker = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(417, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(181, 67);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Project";
            // 
            // target_fund
            // 
            this.target_fund.BackColor = System.Drawing.Color.Transparent;
            this.target_fund.Font = new System.Drawing.Font("Tahoma", 11F);
            this.target_fund.ForeColor = System.Drawing.Color.DimGray;
            this.target_fund.Image = null;
            this.target_fund.Location = new System.Drawing.Point(232, 183);
            this.target_fund.MaxLength = 32767;
            this.target_fund.Multiline = false;
            this.target_fund.Name = "target_fund";
            this.target_fund.ReadOnly = false;
            this.target_fund.Size = new System.Drawing.Size(289, 50);
            this.target_fund.TabIndex = 1;
            this.target_fund.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.target_fund.UseSystemPasswordChar = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(22, 188);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(204, 45);
            this.bigLabel2.TabIndex = 2;
            this.bigLabel2.Text = "Traget Fund :";
            // 
            // description
            // 
            this.description.AutoWordSelection = false;
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.BaseColor = System.Drawing.Color.Transparent;
            this.description.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.description.EdgeColor = System.Drawing.Color.White;
            this.description.Font = new System.Drawing.Font("Tahoma", 10F);
            this.description.ForeColor = System.Drawing.Color.DimGray;
            this.description.Location = new System.Drawing.Point(30, 322);
            this.description.Name = "description";
            this.description.ReadOnly = false;
            this.description.Size = new System.Drawing.Size(503, 330);
            this.description.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.description.TabIndex = 3;
            this.description.TextBackColor = System.Drawing.Color.White;
            this.description.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.TextFont = new System.Drawing.Font("Tahoma", 10F);
            this.description.WordWrap = true;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(22, 254);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(256, 54);
            this.bigLabel3.TabIndex = 2;
            this.bigLabel3.Text = "Description : ";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(712, 68);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(247, 187);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(761, 292);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(155, 47);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Tahoma", 11F);
            this.title.ForeColor = System.Drawing.Color.DimGray;
            this.title.Image = null;
            this.title.Location = new System.Drawing.Point(158, 107);
            this.title.MaxLength = 32767;
            this.title.Multiline = false;
            this.title.Name = "title";
            this.title.ReadOnly = false;
            this.title.Size = new System.Drawing.Size(289, 50);
            this.title.TabIndex = 1;
            this.title.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.title.UseSystemPasswordChar = false;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(22, 103);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(130, 54);
            this.bigLabel4.TabIndex = 2;
            this.bigLabel4.Text = "Title : ";
            // 
            // btn_createproject
            // 
            this.btn_createproject.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createproject.Location = new System.Drawing.Point(630, 466);
            this.btn_createproject.Name = "btn_createproject";
            this.btn_createproject.Size = new System.Drawing.Size(286, 113);
            this.btn_createproject.TabIndex = 5;
            this.btn_createproject.Text = "Create Project";
            this.btn_createproject.UseVisualStyleBackColor = true;
            this.btn_createproject.Click += new System.EventHandler(this.btn_createproject_Click);
            // 
            // current_checker
            // 
            this.current_checker.AutoSize = true;
            this.current_checker.Location = new System.Drawing.Point(30, 690);
            this.current_checker.Name = "current_checker";
            this.current_checker.Size = new System.Drawing.Size(105, 24);
            this.current_checker.TabIndex = 6;
            this.current_checker.Text = "Is Current";
            this.current_checker.UseVisualStyleBackColor = true;
            // 
            // fromproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 767);
            this.Controls.Add(this.current_checker);
            this.Controls.Add(this.btn_createproject);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.description);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.bigLabel4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.target_fund);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fromproject";
            this.Text = "fromproject";
            this.Load += new System.EventHandler(this.fromproject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigTextBox target_fund;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.RichTextBoxEdit description;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btn_upload;
        private ReaLTaiizor.Controls.BigTextBox title;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private System.Windows.Forms.Button btn_createproject;
        private System.Windows.Forms.CheckBox current_checker;
    }
}