
namespace LocalMovieApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_username = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_password = new PlaceholderTextBox.PlaceholderTextBox();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(500, 165);
            this.tb_username.Name = "tb_username";
            this.tb_username.PlaceholderText = "Username";
            this.tb_username.Size = new System.Drawing.Size(320, 37);
            this.tb_username.TabIndex = 10;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(500, 222);
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.Size = new System.Drawing.Size(320, 37);
            this.tb_password.TabIndex = 11;
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showPassword.Location = new System.Drawing.Point(500, 284);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(145, 24);
            this.cb_showPassword.TabIndex = 15;
            this.cb_showPassword.Text = "Show password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(496, 364);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(320, 37);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Sign in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(496, 323);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 19);
            this.lbl_status.TabIndex = 13;
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_register.Location = new System.Drawing.Point(509, 438);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(292, 20);
            this.link_register.TabIndex = 16;
            this.link_register.TabStop = true;
            this.link_register.Text = "Don\'t you have an account? Register now.";
            this.link_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_register_LinkClicked);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(527, 35);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(258, 75);
            this.label_welcome.TabIndex = 18;
            this.label_welcome.Text = "Welcome";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Adobe Garamond Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(620, 105);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(148, 22);
            this.label_login.TabIndex = 19;
            this.label_login.Text = "Nice to see you again";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocalMovieApp.Properties.Resources.design1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 519);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox.PlaceholderTextBox tb_username;
        private PlaceholderTextBox.PlaceholderTextBox tb_password;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_login;
    }
}