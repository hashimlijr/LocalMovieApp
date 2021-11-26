using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalMovieApp
{
    public partial class MovieDetail : Form
    {
        public string moviename;
        public string director;
        public string description;
        public string genre;
        public int movieId;
        public byte[] bytes;

        public MovieDetail(int id, string name, string director, string description, string genre, byte[] bytes)
        {
            InitializeComponent();
            this.moviename = name;
            this.director = director;
            this.description = description;
            this.genre = genre;
            this.movieId = id;
            this.bytes = bytes;
        }

        private void MovieDetail_Load(object sender, EventArgs e)
        {
            tb_name.Text = moviename;
            tb_director.Text = director;
            tb_description.Text = description;
            tb_genre.Text = genre;

            if(moviename == "Dune")
            {
                pb_Dune.Visible = true;
                pb_Interstellar.Visible = false;
            }
            else if(moviename== "Interstellar")
            {
                pb_Dune.Visible = false;
                pb_Interstellar.Visible = true;
            }

            

            Image image = ImageConvert.ByteArrayToImage(bytes);
            //panel_poster.BackgroundImage = image;
        }

        private void MovieDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
