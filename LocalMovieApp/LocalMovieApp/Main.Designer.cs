
namespace LocalMovieApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_addMovie = new System.Windows.Forms.Button();
            this.tb_movieName = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_director = new PlaceholderTextBox.PlaceholderTextBox();
            this.tb_description = new PlaceholderTextBox.PlaceholderTextBox();
            this.cb_genre = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.data_movies = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_id = new PlaceholderTextBox.PlaceholderTextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_photo = new System.Windows.Forms.Button();
            this.label_admin = new System.Windows.Forms.Label();
            this.label_Admincommand = new System.Windows.Forms.Label();
            this.pb_reset = new System.Windows.Forms.PictureBox();
            this.pb_LogOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_addMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addMovie.FlatAppearance.BorderSize = 0;
            this.btn_addMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMovie.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMovie.Location = new System.Drawing.Point(722, 713);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(320, 37);
            this.btn_addMovie.TabIndex = 0;
            this.btn_addMovie.Text = "Add";
            this.btn_addMovie.UseVisualStyleBackColor = false;
            this.btn_addMovie.Click += new System.EventHandler(this.btn_addMovie_Click);
            // 
            // tb_movieName
            // 
            this.tb_movieName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_movieName.Location = new System.Drawing.Point(767, 142);
            this.tb_movieName.Name = "tb_movieName";
            this.tb_movieName.PlaceholderText = "Movie name";
            this.tb_movieName.Size = new System.Drawing.Size(275, 37);
            this.tb_movieName.TabIndex = 10;
            // 
            // tb_director
            // 
            this.tb_director.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_director.Location = new System.Drawing.Point(722, 185);
            this.tb_director.Name = "tb_director";
            this.tb_director.PlaceholderText = "Director of movie";
            this.tb_director.Size = new System.Drawing.Size(320, 37);
            this.tb_director.TabIndex = 11;
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(722, 270);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.PlaceholderText = "Description";
            this.tb_description.Size = new System.Drawing.Size(320, 312);
            this.tb_description.TabIndex = 12;
            // 
            // cb_genre
            // 
            this.cb_genre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_genre.FormattingEnabled = true;
            this.cb_genre.Location = new System.Drawing.Point(722, 588);
            this.cb_genre.Name = "cb_genre";
            this.cb_genre.Size = new System.Drawing.Size(320, 31);
            this.cb_genre.TabIndex = 13;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(718, 660);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 19);
            this.lbl_status.TabIndex = 15;
            // 
            // data_movies
            // 
            this.data_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_movies.Location = new System.Drawing.Point(46, 142);
            this.data_movies.Name = "data_movies";
            this.data_movies.ReadOnly = true;
            this.data_movies.RowHeadersWidth = 51;
            this.data_movies.RowTemplate.Height = 24;
            this.data_movies.Size = new System.Drawing.Size(623, 520);
            this.data_movies.TabIndex = 17;
            this.data_movies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_movies_CellClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Khaki;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(363, 713);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 37);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(722, 142);
            this.tb_id.Name = "tb_id";
            this.tb_id.PlaceholderText = "№";
            this.tb_id.Size = new System.Drawing.Size(39, 37);
            this.tb_id.TabIndex = 19;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(519, 713);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 37);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_photo
            // 
            this.btn_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_photo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_photo.Location = new System.Drawing.Point(722, 228);
            this.btn_photo.Name = "btn_photo";
            this.btn_photo.Size = new System.Drawing.Size(320, 37);
            this.btn_photo.TabIndex = 21;
            this.btn_photo.Text = "Choose photo";
            this.btn_photo.UseVisualStyleBackColor = true;
            this.btn_photo.Click += new System.EventHandler(this.btn_photo_Click);
            // 
            // label_admin
            // 
            this.label_admin.AutoSize = true;
            this.label_admin.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin.Location = new System.Drawing.Point(375, 9);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(375, 75);
            this.label_admin.TabIndex = 22;
            this.label_admin.Text = "Admin Panel";
            // 
            // label_Admincommand
            // 
            this.label_Admincommand.AutoSize = true;
            this.label_Admincommand.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Admincommand.Location = new System.Drawing.Point(42, 106);
            this.label_Admincommand.Name = "label_Admincommand";
            this.label_Admincommand.Size = new System.Drawing.Size(513, 20);
            this.label_Admincommand.TabIndex = 23;
            this.label_Admincommand.Text = "Hello, Boss. Have a good day! You can add movie, update and delete them.";
            // 
            // pb_reset
            // 
            this.pb_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_reset.Image = global::LocalMovieApp.Properties.Resources.circular_arrow;
            this.pb_reset.Location = new System.Drawing.Point(1012, 636);
            this.pb_reset.Name = "pb_reset";
            this.pb_reset.Size = new System.Drawing.Size(30, 30);
            this.pb_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_reset.TabIndex = 25;
            this.pb_reset.TabStop = false;
            this.pb_reset.Click += new System.EventHandler(this.pb_reset_Click);
            // 
            // pb_LogOut
            // 
            this.pb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_LogOut.Image = global::LocalMovieApp.Properties.Resources.logout;
            this.pb_LogOut.Location = new System.Drawing.Point(46, 25);
            this.pb_LogOut.Name = "pb_LogOut";
            this.pb_LogOut.Size = new System.Drawing.Size(30, 30);
            this.pb_LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_LogOut.TabIndex = 24;
            this.pb_LogOut.TabStop = false;
            this.pb_LogOut.Click += new System.EventHandler(this.pb_LogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 770);
            this.Controls.Add(this.pb_reset);
            this.Controls.Add(this.pb_LogOut);
            this.Controls.Add(this.label_Admincommand);
            this.Controls.Add(this.label_admin);
            this.Controls.Add(this.btn_photo);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.data_movies);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cb_genre);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_director);
            this.Controls.Add(this.tb_movieName);
            this.Controls.Add(this.btn_addMovie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addMovie;
        private PlaceholderTextBox.PlaceholderTextBox tb_movieName;
        private PlaceholderTextBox.PlaceholderTextBox tb_director;
        private PlaceholderTextBox.PlaceholderTextBox tb_description;
        private System.Windows.Forms.ComboBox cb_genre;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DataGridView data_movies;
        private System.Windows.Forms.Button btn_update;
        private PlaceholderTextBox.PlaceholderTextBox tb_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_photo;
        private System.Windows.Forms.Label label_admin;
        private System.Windows.Forms.Label label_Admincommand;
        private System.Windows.Forms.PictureBox pb_LogOut;
        private System.Windows.Forms.PictureBox pb_reset;
    }
}

