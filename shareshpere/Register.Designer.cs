﻿namespace shareshpere
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.ul = new System.Windows.Forms.Label();
            this.el = new System.Windows.Forms.Label();
            this.pl = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.password_con = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.loginpage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ul
            // 
            this.ul.AutoSize = true;
            this.ul.BackColor = System.Drawing.Color.White;
            this.ul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ul.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ul.Location = new System.Drawing.Point(171, 58);
            this.ul.Name = "ul";
            this.ul.Size = new System.Drawing.Size(129, 25);
            this.ul.TabIndex = 0;
            this.ul.Text = "Username : ";
            // 
            // el
            // 
            this.el.AutoSize = true;
            this.el.BackColor = System.Drawing.Color.White;
            this.el.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.el.Location = new System.Drawing.Point(166, 131);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(78, 25);
            this.el.TabIndex = 1;
            this.el.Text = "Email :";
            // 
            // pl
            // 
            this.pl.AutoSize = true;
            this.pl.BackColor = System.Drawing.Color.White;
            this.pl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pl.Location = new System.Drawing.Point(166, 204);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(125, 25);
            this.pl.TabIndex = 2;
            this.pl.Text = "Password : ";
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.BackColor = System.Drawing.Color.White;
            this.cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cl.Location = new System.Drawing.Point(162, 282);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(200, 25);
            this.cl.TabIndex = 3;
            this.cl.Text = "Confirm Password :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(167, 86);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(325, 26);
            this.username.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(165, 160);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(325, 26);
            this.email.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(165, 232);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(325, 26);
            this.password.TabIndex = 6;
            // 
            // password_con
            // 
            this.password_con.Location = new System.Drawing.Point(161, 310);
            this.password_con.Name = "password_con";
            this.password_con.Size = new System.Drawing.Size(325, 26);
            this.password_con.TabIndex = 7;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(319, 381);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(97, 32);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Register";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // loginpage
            // 
            this.loginpage.Location = new System.Drawing.Point(713, 12);
            this.loginpage.Name = "loginpage";
            this.loginpage.Size = new System.Drawing.Size(75, 37);
            this.loginpage.TabIndex = 9;
            this.loginpage.Text = "login";
            this.loginpage.UseVisualStyleBackColor = true;
            this.loginpage.Click += new System.EventHandler(this.loginpage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-47, -96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(954, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginpage);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.password_con);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.el);
            this.Controls.Add(this.ul);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ul;
        private System.Windows.Forms.Label el;
        private System.Windows.Forms.Label pl;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox password_con;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button loginpage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}