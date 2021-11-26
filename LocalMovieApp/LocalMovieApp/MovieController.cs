using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMovieApp
{
    public class MovieController
    {
        private readonly Context context = new Context();
        
        public void AddMovie(Movie movie, ImageModel image)
        {
            try
            {
                context.Images.Add(image);
            }
            catch
            {
                Console.WriteLine("Image can't be loaded");
            }
            movie.ImageId = image.Id;
            Movie m = new Movie()
            {
                MovieName = movie.MovieName,
                Director = movie.Director,
                Description = movie.Description,
                Genre = movie.Genre,
                ImageId = movie.ImageId,
            };

            context.Movies.Add(m);
            context.SaveChanges();
        }

        
    }
}
