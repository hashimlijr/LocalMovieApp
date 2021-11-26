
namespace LocalMovieApp
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.tb_name = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_surname = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_username = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_password = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_passwordConfirmation = new PlaceholderTextBox.PlaceholderTextBox();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.link_login = new System.Windows.Forms.LinkLabel();
            this.label_join = new System.Windows.Forms.Label();
            this.label_Greetings = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(30, 479);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 19);
            this.lbl_status.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(30, 520);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(320, 37);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Sign Up";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(34, 215);
            this.tb_name.Name = "tb_name";
            this.tb_name.PlaceholderText = "Name";
            this.tb_name.Size = new System.Drawing.Size(150, 37);
            this.tb_name.TabIndex = 7;
            // 
            // tb_surname
            // 
            this.tb_surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surname.Location = new System.Drawing.Point(204, 215);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.PlaceholderText = "Surname";
            this.tb_surname.Size = new System.Drawing.Size(150, 37);
            this.tb_surname.TabIndex = 8;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(34, 268);
            this.tb_username.Name = "tb_username";
            this.tb_username.PlaceholderText = "Username";
            this.tb_username.Size = new System.Drawing.Size(320, 37);
            this.tb_username.TabIndex = 9;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(34, 320);
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.Size = new System.Drawing.Size(320, 37);
            this.tb_password.TabIndex = 10;
            // 
            // tb_passwordConfirmation
            // 
            this.tb_passwordConfirmation.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordConfirmation.Location = new System.Drawing.Point(34, 373);
            this.tb_passwordConfirmation.Name = "tb_passwordConfirmation";
            this.tb_passwordConfirmation.PlaceholderText = "Confirm password";
            this.tb_passwordConfirmation.Size = new System.Drawing.Size(320, 37);
            this.tb_passwordConfirmation.TabIndex = 11;
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showPassword.Location = new System.Drawing.Point(34, 432);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(145, 24);
            this.cb_showPassword.TabIndex = 12;
            this.cb_showPassword.Text = "Show password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // link_login
            // 
            this.link_login.AutoSize = true;
            this.link_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_login.Location = new System.Drawing.Point(32, 585);
            this.link_login.Name = "link_login";
            this.link_login.Size = new System.Drawing.Size(311, 20);
            this.link_login.TabIndex = 17;
            this.link_login.TabStop = true;
            this.link_login.Text = "Do you already have an account? Login now.";
            this.link_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_login_LinkClicked);
            // 
            // label_join
            // 
            this.label_join.AutoSize = true;
            this.label_join.Font = new System.Drawing.Font("Adobe Garamond Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_join.Location = new System.Drawing.Point(115, 138);
            this.label_join.Name = "label_join";
            this.label_join.Size = new System.Drawing.Size(168, 22);
            this.label_join.TabIndex = 21;
            this.label_join.Text = "Join the world of movies";
            // 
            // label_Greetings
            // 
            this.label_Greetings.AutoSize = true;
            this.label_Greetings.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Greetings.Location = new System.Drawing.Point(59, 63);
            this.label_Greetings.Name = "label_Greetings";
            this.label_Greetings.Size = new System.Drawing.Size(260, 75);
            this.label_Greetings.TabIndex = 20;
            this.label_Greetings.Text = "Greetings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocalMovieApp.Properties.Resources.pulpfictionDesign;
            this.pictureBox1.Location = new System.Drawing.Point(392, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 716);
            this.Controls.Add(this.label_join);
            this.Controls.Add(this.label_Greetings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link_login);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.tb_passwordConfirmation);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_register;
        private PlaceholderTextBox.PlaceholderTextBox tb_name;
        private PlaceholderTextBox.PlaceholderTextBox tb_surname;
        private PlaceholderTextBox.PlaceholderTextBox tb_username;
        private PlaceholderTextBox.PlaceholderTextBox tb_password;
        private PlaceholderTextBox.PlaceholderTextBox tb_passwordConfirmation;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.LinkLabel link_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_join;
        private System.Windows.Forms.Label label_Greetings;
    }
}