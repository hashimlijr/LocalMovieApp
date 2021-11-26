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
    public partial class UserMain : Form
    {
        public string name;
        public int id;
        public UserMain(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
        }

        private readonly Context context = new Context();
        private void UserMain_Load(object sender, EventArgs e)
        {
            label_name.Text = "Hello, " + name;
            
            
            // See movie details

            data_movies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Movie> movies = context.Movies.ToList();

            data_movies.DataSource = movies;

        }
        public string moviename;
        public string director;
        public string description;
        public string genre;
        public int movieId;
        private void data_movies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            data_movies.CurrentRow.Selected = true;
            movieId = int.Parse(data_movies.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            moviename = data_movies.Rows[e.RowIndex].Cells["MovieName"].Value.ToString();

            director = data_movies.Rows[e.RowIndex].Cells["Director"].Value.ToString();
            description = data_movies.Rows[e.RowIndex].Cells["Description"].Value.ToString();

            genre = data_movies.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(moviename + " " + director);
            var movie = context.Movies.Find(movieId);
            var image = context.Images.Find(movie.ImageId);
            MovieDetail md = new MovieDetail(movieId, moviename, director, description, genre, image.Data);
            md.Show();
            //this.Hide();
        }

        private void UserMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}
