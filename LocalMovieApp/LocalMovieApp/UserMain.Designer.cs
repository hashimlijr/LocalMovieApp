
namespace LocalMovieApp
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.label_name = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_open = new System.Windows.Forms.Button();
            this.data_movies = new System.Windows.Forms.DataGridView();
            this.label_command = new System.Windows.Forms.Label();
            this.label_Dashboard = new System.Windows.Forms.Label();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(22, 111);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(64, 25);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pb_LogOut);
            this.panel_main.Controls.Add(this.label_Dashboard);
            this.panel_main.Controls.Add(this.label_command);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.btn_open);
            this.panel_main.Controls.Add(this.data_movies);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(620, 748);
            this.panel_main.TabIndex = 1;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(310, 663);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(285, 57);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "See details";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // data_movies
            // 
            this.data_movies.AllowUserToAddRows = false;
            this.data_movies.AllowUserToDeleteRows = false;
            this.data_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_movies.Location = new System.Drawing.Point(26, 204);
            this.data_movies.Name = "data_movies";
            this.data_movies.ReadOnly = true;
            this.data_movies.RowHeadersWidth = 51;
            this.data_movies.RowTemplate.Height = 24;
            this.data_movies.Size = new System.Drawing.Size(569, 453);
            this.data_movies.TabIndex = 0;
            this.data_movies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_movies_CellClick);
            // 
            // label_command
            // 
            this.label_command.AutoSize = true;
            this.label_command.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_command.Location = new System.Drawing.Point(26, 160);
            this.label_command.Name = "label_command";
            this.label_command.Size = new System.Drawing.Size(509, 20);
            this.label_command.TabIndex = 2;
            this.label_command.Text = "Select which movie you want to see, then click on the \"See details\" button.";
            // 
            // label_Dashboard
            // 
            this.label_Dashboard.AutoSize = true;
            this.label_Dashboard.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dashboard.Location = new System.Drawing.Point(174, 9);
            this.label_Dashboard.Name = "label_Dashboard";
            this.label_Dashboard.Size = new System.Drawing.Size(297, 75);
            this.label_Dashboard.TabIndex = 21;
            this.label_Dashboard.Text = "Dashboard";
            // 
            // pb_LogOut
            // 
            this.pb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_LogOut.Image = global::LocalMovieApp.Properties.Resources.logout;
            this.pb_LogOut.Location = new System.Drawing.Point(26, 12);
            this.pb_LogOut.Name = "pb_LogOut";
            this.pb_LogOut.Size = new System.Drawing.Size(30, 30);
            this.pb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_LogOut.TabIndex = 25;
            this.pb_LogOut.TabStop = false;
            this.pb_LogOut.Click += new System.EventHandler(this.pb_LogOut_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 748);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMain_FormClosed);
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView data_movies;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label_command;
        private System.Windows.Forms.Label label_Dashboard;
        private System.Windows.Forms.PictureBox pb_LogOut;
    }
}