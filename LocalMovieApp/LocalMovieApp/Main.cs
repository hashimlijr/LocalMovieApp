using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalMovieApp
{
    public partial class Main : Form
    {
        //Main for Admin
        public Main()
        {
            InitializeComponent();
        }
        private readonly Context context = new Context();

        public void RefreshData()
        {
            data_movies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Movie> movies = context.Movies.ToList();

            data_movies.DataSource = movies;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            cb_genre.Items.Add("Drama");
            cb_genre.Items.Add("Comedy");
            cb_genre.Items.Add("Action");
            cb_genre.Items.Add("Adventure");
            cb_genre.Items.Add("Thriller");
            cb_genre.Items.Add("Animation");
            cb_genre.Items.Add("Romantic");
            cb_genre.Items.Add("Fantasy");
            cb_genre.Items.Add("Sci-fi");

            RefreshData();
        }

        // Add movie
        private ImageModel image;
        private void btn_addMovie_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string name = tb_movieName.Text.Trim();
            string director = tb_director.Text.Trim();
            string description = tb_description.Text.Trim();
            //double imdb = double.Parse(tb_IMDB.Text.Trim());
            string genre = (string)cb_genre.SelectedItem;

            //MessageBox.Show(name + director + description + imdb.ToString() + genre);

            if (!(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(director) || String.IsNullOrEmpty(description) || String.IsNullOrEmpty(genre)))
            {
                if(image == null)
                {
                    sb.Append("Please choose photo");
                }
                else
                {
                    Movie movie = new Movie()
                    {
                        MovieName = name,
                        Director = director,
                        Description = description,
                        Genre = genre,
                    };

                    MovieController movieController = new MovieController();
                    movieController.AddMovie(movie, image);

                    RefreshData();
                    sb.Append("Movie succesfully added.");

                    ClearData();
                }
            }
            else sb.Append("Fill all fields.");

            lbl_status.Text = sb.ToString();
        
    }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Update movie's information
        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = tb_movieName.Text;
            string director = tb_director.Text;
            string description = tb_description.Text;
            string genre = cb_genre.Text;

            var updatedData = context.Movies.Find(int.Parse(tb_id.Text));
            updatedData.MovieName = name;
            updatedData.Director = director;
            updatedData.Description = description;
            updatedData.Genre = genre;

            context.SaveChanges();
            RefreshData();
            ClearData();

            lbl_status.Text = "Movie was updated";
        }

        

        private void data_movies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            data_movies.CurrentRow.Selected = true;
            tb_id.Text = data_movies.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            tb_movieName.Text = data_movies.Rows[e.RowIndex].Cells["MovieName"].Value.ToString();
            
            tb_director.Text = data_movies.Rows[e.RowIndex].Cells["Director"].Value.ToString();
            tb_description.Text = data_movies.Rows[e.RowIndex].Cells["Description"].Value.ToString();

            cb_genre.Text = data_movies.Rows[e.RowIndex].Cells["Genre"].Value.ToString();

        }

        // Delete movie
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_id.Text);
            var deletedData = context.Movies.Find(id);

            context.Movies.Remove(deletedData);
            context.SaveChanges();
            RefreshData();
            ClearData();
            lbl_status.Text = "Movie was deleted";
        }

        public void ClearData()
        {
            tb_id.Text = "";
            tb_movieName.Text = "";
            tb_director.Text = "";
            tb_description.Text = "";
            cb_genre.Text = "";
            
        }
        
        private void btn_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                image = new ImageModel();
                image.Name = String.IsNullOrEmpty(tb_movieName.Text) ? "Image" : tb_movieName.Text;
                try
                {
                    image.Data = ImageConvert.ImageToByteArray(ofd.FileName);
                    image.ImageFormat = Path.GetExtension(ofd.FileName);
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.ToString());
                }
            }
            return;
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pb_reset_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
