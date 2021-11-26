
namespace LocalMovieApp
{
    partial class MovieDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetail));
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_director = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.panel_poster = new System.Windows.Forms.Panel();
            this.pb_Interstellar = new System.Windows.Forms.PictureBox();
            this.pb_Dune = new System.Windows.Forms.PictureBox();
            this.panel_poster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Interstellar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dune)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.Control;
            this.tb_name.Enabled = false;
            this.tb_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(69, 342);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(217, 49);
            this.tb_name.TabIndex = 0;
            // 
            // tb_director
            // 
            this.tb_director.BackColor = System.Drawing.SystemColors.Control;
            this.tb_director.Enabled = false;
            this.tb_director.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_director.Location = new System.Drawing.Point(69, 397);
            this.tb_director.Name = "tb_director";
            this.tb_director.Size = new System.Drawing.Size(217, 29);
            this.tb_director.TabIndex = 1;
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Control;
            this.tb_description.Enabled = false;
            this.tb_description.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(69, 467);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(441, 185);
            this.tb_description.TabIndex = 2;
            // 
            // tb_genre
            // 
            this.tb_genre.BackColor = System.Drawing.SystemColors.Control;
            this.tb_genre.Enabled = false;
            this.tb_genre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_genre.Location = new System.Drawing.Point(69, 432);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(217, 29);
            this.tb_genre.TabIndex = 3;
            // 
            // panel_poster
            // 
            this.panel_poster.Controls.Add(this.pb_Interstellar);
            this.panel_poster.Controls.Add(this.pb_Dune);
            this.panel_poster.Location = new System.Drawing.Point(69, 30);
            this.panel_poster.Name = "panel_poster";
            this.panel_poster.Size = new System.Drawing.Size(234, 295);
            this.panel_poster.TabIndex = 4;
            // 
            // pb_Interstellar
            // 
            this.pb_Interstellar.Image = global::LocalMovieApp.Properties.Resources.interstellar;
            this.pb_Interstellar.Location = new System.Drawing.Point(0, 0);
            this.pb_Interstellar.Name = "pb_Interstellar";
            this.pb_Interstellar.Size = new System.Drawing.Size(234, 295);
            this.pb_Interstellar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Interstellar.TabIndex = 6;
            this.pb_Interstellar.TabStop = false;
            // 
            // pb_Dune
            // 
            this.pb_Dune.Image = global::LocalMovieApp.Properties.Resources.dune;
            this.pb_Dune.Location = new System.Drawing.Point(3, 0);
            this.pb_Dune.Name = "pb_Dune";
            this.pb_Dune.Size = new System.Drawing.Size(234, 295);
            this.pb_Dune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Dune.TabIndex = 5;
            this.pb_Dune.TabStop = false;
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 683);
            this.Controls.Add(this.panel_poster);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_director);
            this.Controls.Add(this.tb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieDetail";
            this.Load += new System.EventHandler(this.MovieDetail_Load);
            this.panel_poster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Interstellar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dune)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_director;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.Panel panel_poster;
        private System.Windows.Forms.PictureBox pb_Dune;
        private System.Windows.Forms.PictureBox pb_Interstellar;
    }
}