namespace shareshpere
{
    partial class fromusers
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
            this.searchbox = new ReaLTaiizor.Controls.AloneTextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.userdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Transparent;
            this.searchbox.EnabledCalc = true;
            this.searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbox.Location = new System.Drawing.Point(51, 34);
            this.searchbox.MaxLength = 32767;
            this.searchbox.MultiLine = false;
            this.searchbox.Name = "searchbox";
            this.searchbox.ReadOnly = false;
            this.searchbox.Size = new System.Drawing.Size(441, 42);
            this.searchbox.TabIndex = 0;
            this.searchbox.Text = "Search....";
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbox.UseSystemPasswordChar = false;
            // 
            // btn_search
            // 
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_search.Image = global::shareshpere.Properties.Resources.icons8_search_502;
            this.btn_search.Location = new System.Drawing.Point(555, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 57);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // userdata
            // 
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdata.Location = new System.Drawing.Point(20, 109);
            this.userdata.Name = "userdata";
            this.userdata.RowHeadersWidth = 62;
            this.userdata.RowTemplate.Height = 28;
            this.userdata.Size = new System.Drawing.Size(1038, 427);
            this.userdata.TabIndex = 2;
            // 
            // fromusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 566);
            this.Controls.Add(this.userdata);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fromusers";
            this.Text = "fromusers";
            this.Load += new System.EventHandler(this.fromusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AloneTextBox searchbox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView userdata;
    }
}